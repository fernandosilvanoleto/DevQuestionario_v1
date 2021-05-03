using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Core.Entities
{
    public class Questionario : BaseEntity
    {
        public Questionario(int idCriadorUsuario, string titulo, string descricao)
        {
            IdCriadorUsuario = idCriadorUsuario;
            Titulo = titulo;
            Descricao = descricao;

            StatusQuestionario = QuestionarioEnum.Ativo;
            DataCriacao = DateTime.Now;

            Entrevistas = new List<Entrevista>();
            QuestionarioPerguntas = new List<QuestionarioPergunta>();
        }

        public int IdCriadorUsuario { get; private set; }
        public Cliente CriadorUsuario { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public QuestionarioEnum StatusQuestionario { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public List<Entrevista> Entrevistas { get; private set; }
        public List<QuestionarioPergunta> QuestionarioPerguntas { get; private set; }




        // MÉTODOS
        public void Remover()
        {
            if (StatusQuestionario == QuestionarioEnum.Ativo)
            {
                StatusQuestionario = QuestionarioEnum.Excluido;
            }
        }

        public void Recuperar()
        {
            if (StatusQuestionario == QuestionarioEnum.Excluido)
            {
                StatusQuestionario = QuestionarioEnum.Ativo;
            }
        }

        public void Update(string titulo, string descricao)
        {
            if (titulo != null && descricao != null)
            {
                this.Titulo = titulo;
                this.Descricao = descricao;
            }
        }

    }
}
