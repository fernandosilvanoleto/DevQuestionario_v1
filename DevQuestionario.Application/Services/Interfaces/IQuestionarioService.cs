using DevQuestionario.Application.InputModels.Questionario;
using DevQuestionario.Application.ViewModels.Questionario;
using System.Collections.Generic;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IQuestionarioService
    {
        List<QuestionarioViewModel> GetAllQuestionario();
        QuestionarioByIdViewModel GetByIdQuestionario(int id);
        List<QuestionarioByIdViewModel> GetByIdQuestionarioByCliente(int idCriador);
        int CreateQuestionario(CreateQuestionarioInputModel inputModel);
        int? UpdateQuestionario(UpdateQuestionarioInputModel inputModel);
        int? RemoverQuestionario(int id);
        int? RecuperarQuestionario(int id);
    }
}
