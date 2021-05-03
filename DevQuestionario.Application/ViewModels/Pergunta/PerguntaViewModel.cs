using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.ViewModels.Pergunta
{
    public class PerguntaViewModel
    {
        public PerguntaViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
    }
}
