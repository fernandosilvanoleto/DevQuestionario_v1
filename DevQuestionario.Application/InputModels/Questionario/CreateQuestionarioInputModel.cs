using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.InputModels.Questionario
{
    public class CreateQuestionarioInputModel
    {
        public int IdCriadorUsuario { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Título é obrigatório.")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatório.")]
        public string Descricao { get; set; }
    }
}
