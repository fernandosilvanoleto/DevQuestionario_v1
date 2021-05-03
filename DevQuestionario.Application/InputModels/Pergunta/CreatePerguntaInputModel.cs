
using System.ComponentModel.DataAnnotations;

namespace DevQuestionario.Application.InputModels.Pergunta
{
    public class CreatePerguntaInputModel
    {
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A descrição é requerido.")]
        public string Descricao { get; set; }
    }
}
