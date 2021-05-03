using System.ComponentModel.DataAnnotations;

namespace DevQuestionario.Application.ViewModels.Area
{
    public class AreaAllViewModel
    {
        public AreaAllViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        [Display(Name = "Identificação")]
        public int Id { get; private set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }
    }
}
