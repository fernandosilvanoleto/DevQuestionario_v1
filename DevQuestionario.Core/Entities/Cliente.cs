using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;

namespace DevQuestionario.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente(string nome, string email, string userLogin, string senhaLogin)
        {
            Nome = nome;
            Email = email;

            UserLogin = userLogin;
            SenhaLogin = senhaLogin;

            DataCriacao = DateTime.Now;
            StatusCliente = ClienteEnum.Ativo;

            Questionarios = new List<Questionario>();
            Entrevistas = new List<Entrevista>();
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public ClienteEnum StatusCliente { get; private set; }

        public string UserLogin { get; private set; }
        public string SenhaLogin { get; private set; }

        public List<Questionario> Questionarios { get; private set; }
        public List<Entrevista> Entrevistas { get; private set; }

        // MÉTODOS
        public void Suspender()
        {
            if (StatusCliente == ClienteEnum.Ativo)
            {
                StatusCliente = ClienteEnum.Suspenso;
            }
        }

        public void Reativar()
        {
            if (StatusCliente == ClienteEnum.Suspenso || StatusCliente == ClienteEnum.Excluido)
            {
                StatusCliente = ClienteEnum.Ativo;
            }
        }

        public void Deletar()
        {
            if (StatusCliente == ClienteEnum.Ativo || StatusCliente == ClienteEnum.Suspenso)
            {
                StatusCliente = ClienteEnum.Excluido;
            }
        }

        public void Update(string email)
        {
            if (email != null)
            {
                Email = email;
            }
        }

        public bool Login(string usuarioLogin, string senha)
        {
            if (usuarioLogin == this.Email || usuarioLogin == this.UserLogin)
            {
                if (senha ==  this.SenhaLogin)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
