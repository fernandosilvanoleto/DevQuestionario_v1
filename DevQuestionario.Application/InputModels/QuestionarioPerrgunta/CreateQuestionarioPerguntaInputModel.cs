using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.InputModels.QuestionarioPerrgunta
{
    public class CreateQuestionarioPerguntaInputModel
    {
        public CreateQuestionarioPerguntaInputModel(int idQuestionario, int idPergunta)
        {
            IdQuestionario = idQuestionario;
            IdPergunta = idPergunta;
        }

        public int IdQuestionario { get; set; }
        public int IdPergunta { get; set; }
    }
}
