using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.InputModels.Entrevista
{
    public class CreateEntrevistaInputModel
    {
        public CreateEntrevistaInputModel(int idCliente, int idQuestionario)
        {
            IdCliente = idCliente;
            IdQuestionario = idQuestionario;
        }

        public int IdCliente { get; set; }
        public int IdQuestionario { get; set; }
    }
}
