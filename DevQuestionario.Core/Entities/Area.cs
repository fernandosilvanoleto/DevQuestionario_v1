using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Core.Entities
{
    public class Area : BaseEntity
    {
        public Area(string descricao, string? observacao)
        {
            Descricao = descricao;
            Observacao = observacao;

            RespostaUsuarios = new List<RespostaUsuario>();

        }

        public string Descricao { get; private set; }
        public string? Observacao { get; private set; }

        public List<RespostaUsuario> RespostaUsuarios { get; private set; }
    }
}
