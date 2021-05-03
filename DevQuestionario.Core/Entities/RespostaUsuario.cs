using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Core.Entities
{
    public class RespostaUsuario : BaseEntity
    {
        public RespostaUsuario(int idEntrevista, int idPergunta)
        {
            IdEntrevista = idEntrevista;
            IdPergunta = idPergunta;

            DataHoraGeracao = DateTime.Now;
        }

        public int IdEntrevista { get; private set; }
        public Entrevista Entrevista { get; private set; }
        public int IdPergunta { get; private set; }
        public Pergunta Perguntas { get; private set; }
        public int? IdArea { get; private set; }
        public Area? Area { get; private set; }
        public string Localizacao { get; private set; }
        public string? Resposta { get; private set; }
        public DateTime DataHoraResposta { get; private set; }
        public DateTime DataHoraGeracao { get; private set; }

        public void RespostaPergunta(string resposta, string localizacao)
        {
            this.Resposta = resposta;
            this.Localizacao = localizacao;
            DataHoraResposta = DateTime.Now;
        }

    }
}
