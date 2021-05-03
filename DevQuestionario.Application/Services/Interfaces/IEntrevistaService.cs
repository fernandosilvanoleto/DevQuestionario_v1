using DevQuestionario.Application.InputModels.Entrevista;
using DevQuestionario.Application.ViewModels.Entrevista;
using System.Collections.Generic;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IEntrevistaService
    {
        List<EntrevistaAllViewModel> GetAllEntrevista();
        EntrevistaByIdViewModel GetByIdEntrevista(int id);
        List<EntrevistaAllClienteViewModel> GetAllEntrevistaByCliente(int idCliente);
        int CreateEntrevista(CreateEntrevistaInputModel inputModel);
        void UpdateEntrevista(UpdateEntrevistaInputModel inputModel);
        void Remover(int id);
        void Recuperar(int id);
        int RecuperarClienteByIdEntrevista(int idEntrevista);
    }
}
