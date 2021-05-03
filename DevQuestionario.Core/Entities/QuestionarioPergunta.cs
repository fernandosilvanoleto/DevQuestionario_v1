using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Core.Entities
{
    public class QuestionarioPergunta : BaseEntity
    {
        public QuestionarioPergunta(int idQuestionario, int idPergunta)
        {
            IdQuestionario = idQuestionario;
            IdPergunta = idPergunta;

            DataCriacao = DateTime.Now;

            StatusQuestionarioPergunta = QuestionarioPerguntaEnum.Ativo;
        }

        public int IdQuestionario { get; private set; }
        public Questionario Questionario { get; private set; }
        public int IdPergunta { get; private set; }
        public Pergunta Perguntas { get; private set; }
        public QuestionarioPerguntaEnum StatusQuestionarioPergunta { get; private set; }
        public DateTime DataCriacao { get; private set; }

        // MÉTODOS
        public void Inativar()
        {
            if (StatusQuestionarioPergunta == QuestionarioPerguntaEnum.Ativo)
            {
                StatusQuestionarioPergunta = QuestionarioPerguntaEnum.Inativo;
            }
        }

        public void Reativar()
        {
            if (StatusQuestionarioPergunta == QuestionarioPerguntaEnum.Inativo)
            {
                StatusQuestionarioPergunta = QuestionarioPerguntaEnum.Ativo;
            }
        }
    }
}
