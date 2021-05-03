using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.InputModels.Entrevista
{
    public class UpdateEntrevistaInputModel
    {
        public int Id { get; set; }
        public int IdQuestionario { get; set; }
        public int IdArea { get; set; }
    }
}
