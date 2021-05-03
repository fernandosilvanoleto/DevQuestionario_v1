using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.ViewModels.QuestionarioPergunta
{
    public class QuestionarioPerguntaByIdViewModel
    {
        public QuestionarioPerguntaByIdViewModel(int id, int idQuestionario, string questionario, int idPergunta, string perguntas, QuestionarioPerguntaEnum statusQuestionarioPergunta, DateTime dataCriacao)
        {
            Id = id;
            IdQuestionario = idQuestionario;
            Questionario = questionario;
            IdPergunta = idPergunta;
            Perguntas = perguntas;
            StatusQuestionarioPergunta = Enum.GetName(typeof(QuestionarioPerguntaEnum), statusQuestionarioPergunta);
            DataCriacao = dataCriacao;
        }

        public int Id { get; private set; }
        public int IdQuestionario { get; private set; }
        public string Questionario { get; private set; }
        public int IdPergunta { get; private set; }
        public string Perguntas { get; private set; }
        public string StatusQuestionarioPergunta { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
