using DevQuestionario.Core.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace DevQuestionario.Application.ViewModels.Cliente
{
    public class ClienteAllViewModel
    {
        public ClienteAllViewModel(int id, string nome, string email, ClienteEnum statusCliente)
        {
            Id = id;
            Nome = nome;
            Email = email;
            StatusCliente = Enum.GetName(typeof(ClienteEnum), statusCliente);
        }

        [Display(Name = "Código")]
        public int Id { get; private set; }

        public string Nome { get; private set; }
        public string Email { get; private set; }

        [Display(Name = "Status")]
        public string StatusCliente { get; private set; }
    }
}
