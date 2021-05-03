using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevQuestionario.Application.ViewModels.RespostaUsuario
{
    public class GetAllRespostaUsuarioByEntrevistaViewModel
    {
        public GetAllRespostaUsuarioByEntrevistaViewModel(int idResposta, int idPergunta, string pergunta, int idEntrevista, string resposta, DateTime dataHoraResposta, string localizacaoAtual)
        {
            IdResposta = idResposta;
            IdPergunta = idPergunta;
            Pergunta = pergunta;
            IdEntrevista = idEntrevista;
            Resposta = resposta;
            DataHoraResposta = dataHoraResposta;
            LocalizacaoAtual = localizacaoAtual;
        }

        // TRAZER INFORMAÇÕES PARA SEREM RESPONDIDAS
        public int IdResposta { get; set; }

        [Display(Name = "Código Pergunta")]
        public int IdPergunta { get; set; }
        public string Pergunta { get; set; }

        [Display(Name = "Código Entrevista")]
        public int IdEntrevista { get; set; }
        public string Resposta { get; set; }

        [Display(Name = "Data da Resposta")]
        public DateTime DataHoraResposta { get; set; }

        [Display(Name = "Localização Atual")]
        public string LocalizacaoAtual { get; set; }
    }
}
