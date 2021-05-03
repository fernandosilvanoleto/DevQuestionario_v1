using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Entrevista
{
    public class EntrevistaAllClienteViewModel
    {
        public EntrevistaAllClienteViewModel(int idEntrevista, int idQuestionario, string nomeQuestionario, int idCliente, DateTime dataCriacao)
        {
            IdEntrevista = idEntrevista;
            IdQuestionario = idQuestionario;
            NomeQuestionario = nomeQuestionario;
            IdCliente = idCliente;
            DataCriacao = dataCriacao;
        }
        [Display(Name = "Código da Entrevista")]
        public int IdEntrevista { get; private set; }
        public int IdQuestionario { get; private set; }

        [Display(Name = "Questionário")]
        public string NomeQuestionario { get; private set; }
        public int IdCliente { get; private set; }

        [Display(Name = "Criado em")]
        public DateTime DataCriacao { get; private set; }
    }
}
