using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Entrevista
{
    public class EntrevistaByIdViewModel
    {
        public EntrevistaByIdViewModel(int id, int idCliente, string cliente, string questionario, EntrevistaEnum statusEntrevista, DateTime dataCriacao)
        {
            this.Id = id;
            this.cliente = cliente;
            this.IdCliente = idCliente;
            this.questionario = questionario;
            StatusEntrevista = Enum.GetName(typeof(EntrevistaEnum), statusEntrevista);
            DataCriacao = dataCriacao;
        }
        public int Id { get; private set; }
        public int IdCliente { get; private set; }
        public string cliente { get; private set; }
        public string questionario { get; private set; }
        public string StatusEntrevista { get; private set; }
        public DateTime DataCriacao { get; private set; }

    }
}
