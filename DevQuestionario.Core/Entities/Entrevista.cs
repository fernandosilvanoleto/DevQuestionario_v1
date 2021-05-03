using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Core.Entities
{
    public class Entrevista : BaseEntity
    {
        public Entrevista(int idCliente, int idQuestionario)
        {
            IdCliente = idCliente;
            IdQuestionario = idQuestionario;

            StatusEntrevista = EntrevistaEnum.Ativo;
            DataCriacao = DateTime.Now;

            RespostaUsuarios = new List<RespostaUsuario>();
        }

        public int IdCliente { get; private set; }
        public Cliente Entrevistado { get; private set; }
        public int IdQuestionario { get; private set; }
        public Questionario Questionario { get; private set; }
        public EntrevistaEnum StatusEntrevista { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public List<RespostaUsuario> RespostaUsuarios { get; private set; }


        // MÉTODOS
        public void Remover()
        {
            if (StatusEntrevista == EntrevistaEnum.Ativo)
            {
                StatusEntrevista = EntrevistaEnum.Excluido;
            }
        }

        public void Recuperar()
        {
            if (StatusEntrevista == EntrevistaEnum.Excluido)
            {
                StatusEntrevista = EntrevistaEnum.Ativo;
            }
        }

        public void Update(int idQuestionario, int idArea)
        {
            this.IdQuestionario = idQuestionario;
        }

    }
}
