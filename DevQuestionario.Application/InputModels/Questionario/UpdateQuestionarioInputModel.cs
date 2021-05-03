using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.InputModels.Questionario
{
    public class UpdateQuestionarioInputModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
