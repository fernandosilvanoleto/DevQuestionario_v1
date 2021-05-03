using DevQuestionario.Application.InputModels.Pergunta;
using DevQuestionario.Application.ViewModels.Pergunta;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IPerguntaService
    {
        List<PerguntaViewModel> GetAllPergunta();
        PerguntaByIdViewModel GetByIdPergunta(int id);
        int CreatePergunta(CreatePerguntaInputModel inputModel);
        int? UpdatePergunta(UpdatePerguntaInputModel inputModel);
    }
}
