using DevQuestionario.Application.InputModels.Cliente;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.Cliente;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevQuestionario.Application.Services.Implementations
{
    public class ClienteService : IClienteService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public ClienteService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateCliente(NewClienteInputModel inputModel)
        {
            var cliente = new Cliente(inputModel.NomeCompleto, inputModel.Email, inputModel.UserLogin, inputModel.SenhaLogin);

            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();

            return cliente.Id;
        }

        public void Deletar(int id)
        {
            var cliente = _dbContext.Clientes.SingleOrDefault(a => a.Id == id);

            cliente.Deletar();
            _dbContext.SaveChanges();
        }

        public List<ClienteAllViewModel> GetAllCliente()
        {
            var clientes = _dbContext.Clientes;

            if (clientes == null)
            {
                return null;
            }

            var clienteAllViewModel = clientes
                .Select(c => new ClienteAllViewModel(c.Id, c.Nome, c.Email, c.StatusCliente))
                .ToList();

            return clienteAllViewModel;
        }

        public ClienteByIdViewModel GetByIdCliente(int id)
        {
            var cliente = _dbContext.Clientes.SingleOrDefault(a => a.Id == id);

            var clienteByIdViewModel = new ClienteByIdViewModel(
                    cliente.Id,
                    cliente.Nome,
                    cliente.Email,
                    cliente.DataCriacao,
                    cliente.StatusCliente
                );

            return clienteByIdViewModel;
        }

        public int LoginCliente(LoginClienteInputModel inputModel)
        {
            var cliente = _dbContext.Clientes.SingleOrDefault(a => a.UserLogin == inputModel.UserLogin || a.Email == inputModel.UserLogin);

            if (cliente == null)
            {
                return -1;
            }

            bool retorno = cliente.Login(inputModel.UserLogin, inputModel.SenhaLogin);

            if (retorno == false)
            {
                return -1;
            }

            return cliente.Id;
        }

        public void Reativar(int id)
        {
            var cliente = _dbContext.Clientes.SingleOrDefault(a => a.Id == id);

            cliente.Reativar();
            _dbContext.SaveChanges();
        }

        public void Suspender(int id)
        {
            var cliente = _dbContext.Clientes.SingleOrDefault(a => a.Id == id);

            cliente.Suspender();
            _dbContext.SaveChanges();
        }

        public void UpdateCliente(UpdateClienteInputModel inputModel)
        {
            var cliente = _dbContext.Clientes.SingleOrDefault(a => a.Id == inputModel.Id);

            cliente.Update(inputModel.Email);
            _dbContext.SaveChanges();
        }
    }
}
