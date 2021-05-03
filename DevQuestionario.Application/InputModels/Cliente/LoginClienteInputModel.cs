using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.InputModels.Cliente
{
    public class LoginClienteInputModel
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string SenhaLogin { get; set; }
    }
}
