using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Pergunta
{
    public class PerguntaByIdViewModel
    {
        public PerguntaByIdViewModel(int id, string descricao, DateTime dataCriacao)
        {
            Id = id;
            Descricao = descricao;
            DataCriacao = dataCriacao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
