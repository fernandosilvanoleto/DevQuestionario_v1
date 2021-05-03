using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.InputModels.RespostaUsuario
{
    public class CreateRespostaUsuarioInputModel
    {
        public CreateRespostaUsuarioInputModel(int idEntrevista, int idPergunta)
        {
            IdEntrevista = idEntrevista;
            IdPergunta = idPergunta;
        }

        public int IdEntrevista { get; set; }
        public int IdPergunta { get; set; }
    }
}
