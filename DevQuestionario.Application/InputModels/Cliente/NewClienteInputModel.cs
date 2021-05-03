
using System.ComponentModel.DataAnnotations;

namespace DevQuestionario.Application.InputModels.Cliente
{
    public class NewClienteInputModel
    {
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email é obrigatório.")]
        public string Email { get; set; }

        [Display(Name = "Usuário para Login")]
        [Required(ErrorMessage = "Login é obrigatório.")]
        public string UserLogin { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha é obrigatório.")]
        public string SenhaLogin { get; set; }
    }
}
