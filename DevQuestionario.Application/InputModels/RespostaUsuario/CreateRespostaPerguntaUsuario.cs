using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.InputModels.RespostaUsuario
{
    public class CreateRespostaPerguntaUsuario
    {
        // DADOS PARA USAR PARA O UPDATE
        public int IdResposta { get; set; }
        public int IdPergunta { get; set; }
        public string Pergunta { get; set; }
        public int IdEntrevista { get; set; }
        public string Resposta { get; set; }

        [Display(Name = "Localização Atual")]
        public string LocalizacaoAtual { get; set; }

    }
}
