using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Questionario
{
    public class QuestionarioByIdViewModel
    {
        public QuestionarioByIdViewModel(int id, string criadorUsuario, string titulo, string descricao, QuestionarioEnum statusQuestionario, DateTime dataCriacao)
        {
            Id = id;
            CriadorUsuario = criadorUsuario;
            Titulo = titulo;
            Descricao = descricao;
            StatusQuestionario = Enum.GetName(typeof(QuestionarioEnum), statusQuestionario);
            DataCriacao = dataCriacao;
        }
        [Display(Name = "Código Questionário")]
        public int Id { get; private set; }

        [Display(Name = "Cliente Criador")]
        public string CriadorUsuario { get; private set; }

        [Display(Name = "Título")]
        public string Titulo { get; private set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }

        [Display(Name = "Status")]
        public string StatusQuestionario { get; private set; }

        [Display(Name = "Criado em")]
        public DateTime DataCriacao { get; private set; }
    }
}
