using DevQuestionario.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Entrevista
{
    public class EntrevistaAllViewModel
    {
        public EntrevistaAllViewModel(int id, string cliente, string questionario, EntrevistaEnum statusEntrevista)
        {
            this.Id = id;
            this.cliente = cliente;
            this.questionario = questionario;
            StatusEntrevista = Enum.GetName(typeof(EntrevistaEnum), statusEntrevista); ;
        }
        public int Id { get; private set; }
        public string cliente { get; private set; }
        public string questionario { get; private set; }
        public string StatusEntrevista { get; private set; }
    }
}
