using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.ViewModels.RespostaUsuario
{
    public class RespostaUsuarioByIdViewModel
    {
        public RespostaUsuarioByIdViewModel(int id, int idEntrevista, int idPergunta, string perguntas, int? idArea, string? area, string resposta, DateTime dataHoraResposta)
        {
            Id = id;
            IdEntrevista = idEntrevista;
            IdPergunta = idPergunta;
            Perguntas = perguntas;
            IdArea = idArea;
            Area = area;
            Resposta = resposta;
            DataHoraResposta = dataHoraResposta;
        }

        public int Id { get; private set; }
        public int IdEntrevista { get; private set; }
        public int IdPergunta { get; private set; }
        public string Perguntas { get; private set; }
        public int? IdArea { get; private set; }
        public string? Area { get; private set; }
        public string Resposta { get; private set; }
        public DateTime DataHoraResposta { get; private set; }
    }
}
