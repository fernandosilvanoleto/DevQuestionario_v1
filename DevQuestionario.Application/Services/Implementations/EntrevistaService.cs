using DevQuestionario.Application.InputModels.Entrevista;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.Entrevista;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DevQuestionario.Application.Services.Implementations
{
    public class EntrevistaService : IEntrevistaService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public EntrevistaService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateEntrevista(CreateEntrevistaInputModel inputModel)
        {
            var entrevista = new Entrevista(inputModel.IdCliente, inputModel.IdQuestionario);

            _dbContext.Entrevistas.Add(entrevista);
            _dbContext.SaveChanges();

            return entrevista.Id;
        }

        public List<EntrevistaAllViewModel> GetAllEntrevista()
        {
            var entrevistas = _dbContext.Entrevistas;

            var entrevistaAllViewModel = entrevistas
                .Include(c => c.Entrevistado)
                .Include(q => q.Questionario)
                .Select(e => new EntrevistaAllViewModel(e.Id, e.Entrevistado.Nome, e.Questionario.Titulo, e.StatusEntrevista))
                .ToList();

            if (entrevistaAllViewModel == null) return null;

            return entrevistaAllViewModel;
        }

        public List<EntrevistaAllClienteViewModel> GetAllEntrevistaByCliente(int idCliente)
        {
            var entrevistas = _dbContext.Entrevistas;

            var entrevistaAllClienteViewModel = entrevistas
                .Include(c => c.Entrevistado)
                .Include(q => q.Questionario)
                .Where(c => c.IdCliente == idCliente)
                .Select(e => new EntrevistaAllClienteViewModel(e.Id, e.IdQuestionario, e.Questionario.Titulo, e.IdCliente, e.DataCriacao))
                .ToList();

            if (entrevistaAllClienteViewModel == null) return null;

            return entrevistaAllClienteViewModel;
        }

        public EntrevistaByIdViewModel GetByIdEntrevista(int id)
        {
            var entrevista = _dbContext.Entrevistas
                .Include(c => c.Entrevistado)
                .Include(q => q.Questionario)
                .SingleOrDefault(p => p.Id == id);

            if (entrevista == null) return null;

            var entrevistaByIdViewModel = new EntrevistaByIdViewModel(
                    entrevista.Id,
                    entrevista.IdCliente,
                    entrevista.Entrevistado.Nome,
                    entrevista.Questionario.Titulo,
                    entrevista.StatusEntrevista,
                    entrevista.DataCriacao
                );

            return entrevistaByIdViewModel;
        }

        public void Recuperar(int id)
        {
            var entrevista = _dbContext.Entrevistas.SingleOrDefault(e => e.Id == id);

            if (entrevista != null)
            {
                entrevista.Recuperar();
                _dbContext.SaveChanges();
            }
        }

        public int RecuperarClienteByIdEntrevista(int idEntrevista)
        {
            var entrevista = _dbContext.Entrevistas.SingleOrDefault(e => e.Id == idEntrevista);

            // RETORNAR O ID DO CLIENTE
            return entrevista.IdCliente;
        }

        public void Remover(int id)
        {
            var entrevista = _dbContext.Entrevistas.SingleOrDefault(e => e.Id == id);


            if (entrevista != null)
            {
                entrevista.Remover();
                _dbContext.SaveChanges();
            }
        }

        public void UpdateEntrevista(UpdateEntrevistaInputModel inputModel)
        {
            var entrevista = _dbContext.Entrevistas.SingleOrDefault(e => e.Id == inputModel.Id);

            if (entrevista != null)
            {
                entrevista.Update(inputModel.IdQuestionario, inputModel.IdArea);
                _dbContext.SaveChanges();
            }
        }
    }
}
