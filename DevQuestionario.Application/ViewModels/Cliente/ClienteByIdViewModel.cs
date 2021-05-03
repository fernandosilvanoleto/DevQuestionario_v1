using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Cliente
{
    public class ClienteByIdViewModel
    {
        public ClienteByIdViewModel(int id, string nome, string email, DateTime dataCriacao, ClienteEnum statusCliente)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataCriacao = dataCriacao;
            StatusCliente = Enum.GetName(typeof(ClienteEnum), statusCliente);
        }

        [Display(Name = "Código")]
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        [Display(Name = "Criador em")]
        public DateTime DataCriacao { get; private set; }

        [Display(Name = "Status")]
        public string StatusCliente { get; private set; }
    }
}
