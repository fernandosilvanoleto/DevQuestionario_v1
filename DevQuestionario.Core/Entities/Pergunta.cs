using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Core.Entities
{
    public class Pergunta : BaseEntity
    {
        public Pergunta(string descricao)
        {
            Descricao = descricao;

            DataCriacao = DateTime.Now;

            QuestionarioPerguntas = new List<QuestionarioPergunta>();
            RespostaUsuarios = new List<RespostaUsuario>();
        }

        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public List<QuestionarioPergunta> QuestionarioPerguntas { get; private set; }
        public List<RespostaUsuario> RespostaUsuarios { get; private set; }

        // MÉTODOS
        public void Update(string descricao)
        {
            this.Descricao = descricao;
        }
    }
}
