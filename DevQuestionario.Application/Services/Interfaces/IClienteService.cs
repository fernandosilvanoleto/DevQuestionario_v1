using DevQuestionario.Application.InputModels.Cliente;
using DevQuestionario.Application.ViewModels.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IClienteService
    {
        List<ClienteAllViewModel> GetAllCliente();
        ClienteByIdViewModel GetByIdCliente(int id);
        int CreateCliente(NewClienteInputModel inputModel);
        void UpdateCliente(UpdateClienteInputModel inputModel);
        int LoginCliente(LoginClienteInputModel inputModel);
        void Suspender(int id);
        void Reativar(int id);
        void Deletar(int id);
    }
}
