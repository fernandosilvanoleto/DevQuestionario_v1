using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Area
{
    public class AreaByIdViewModel
    {
        public AreaByIdViewModel(int id, string descricao, string observacao)
        {
            Id = id;
            Descricao = descricao;
            Observacao = observacao;
        }

        [Display(Name = "Código")]
        public int Id { get; private set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }

        [Display(Name = "Observação")]
        public string? Observacao { get; private set; }
    }
}
