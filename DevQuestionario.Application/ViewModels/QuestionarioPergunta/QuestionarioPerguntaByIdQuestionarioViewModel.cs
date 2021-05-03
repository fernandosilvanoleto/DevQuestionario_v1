using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.ViewModels.QuestionarioPergunta
{
    public class QuestionarioPerguntaByIdQuestionarioViewModel
    {
        public QuestionarioPerguntaByIdQuestionarioViewModel(int id, int idCliente, string criador, int idQuestionario, string questionario, int idPergunta, string perguntas, QuestionarioPerguntaEnum statusQuestionarioPergunta, DateTime dataCriacao)
        {
            Id = id;
            IdCliente = idCliente;
            Criador = criador;
            IdQuestionario = idQuestionario;
            Questionario = questionario;
            IdPergunta = idPergunta;
            Perguntas = perguntas;
            StatusQuestionarioPergunta = Enum.GetName(typeof(QuestionarioPerguntaEnum), statusQuestionarioPergunta);
            DataCriacao = dataCriacao;
        }

        public int Id { get; private set; }
        public int IdCliente { get; private set; }
        public string Criador { get; private set; }
        public int IdQuestionario { get; private set; }
        public string Questionario { get; private set; }
        public int IdPergunta { get; private set; }

        [Display(Name = "Pergunta")]
        public string Perguntas { get; private set; }

        [Display(Name = "Status")]
        public string StatusQuestionarioPergunta { get; private set; }

        [Display(Name = "Criado em")]
        public DateTime DataCriacao { get; private set; }
    }
}
