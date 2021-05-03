using DevQuestionario.Core.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace DevQuestionario.Application.ViewModels.Questionario
{
    public class QuestionarioViewModel
    {
        public QuestionarioViewModel(int id, string criadorUsuario, string titulo, string descricao, QuestionarioEnum statusQuestionario)
        {
            Id = id;
            CriadorUsuario = criadorUsuario;
            Titulo = titulo;
            Descricao = descricao;
            StatusQuestionario = Enum.GetName(typeof(QuestionarioEnum), statusQuestionario);
        }
        [Display(Name = "Código")]
        public int Id { get; private set; }

        [Display(Name = "Cliente Criador")]
        public string CriadorUsuario { get; private set; }

        [Display(Name = "Título")]
        public string Titulo { get; private set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }

        [Display(Name = "Status")]
        public string StatusQuestionario { get; private set; }
    }
}
