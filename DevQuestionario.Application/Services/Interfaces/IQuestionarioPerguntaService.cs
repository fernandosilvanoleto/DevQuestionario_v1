using DevQuestionario.Application.InputModels.QuestionarioPerrgunta;
using DevQuestionario.Application.ViewModels.QuestionarioPergunta;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IQuestionarioPerguntaService
    {
        List<QuestionarioPerguntaViewModel> GetAllQuestionarioPergunta();
        QuestionarioPerguntaByIdViewModel GetByIdQuestionarioPergunta(int id);
        List<QuestionarioPerguntaByIdQuestionarioViewModel> GetByIdQuestionarioPerguntaByIdQuestionario(int IdQuestionario);
        int CreateQuestionarioPergunta(CreateQuestionarioPerguntaInputModel inputModel);
        int? InativarQuestionarioPergunta(int id);
        int? ReativarQuestionarioPergunta(int id);
    }
}
