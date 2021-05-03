using System.ComponentModel.DataAnnotations;

namespace DevQuestionario.Application.InputModels.Area
{
    public class CreateAreaInputModel
    {
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é requerida.")]
        public string Descricao { get; set; }

        [Display(Name = "Observação")]
        public string? Observacao { get; set; }
    }
}
