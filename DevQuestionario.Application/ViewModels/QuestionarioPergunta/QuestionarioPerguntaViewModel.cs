﻿using DevQuestionario.Core.Enum;
using System;

namespace DevQuestionario.Application.ViewModels.QuestionarioPergunta
{
    public class QuestionarioPerguntaViewModel
    {
        public QuestionarioPerguntaViewModel(int id, int idQuestionario, string questionario, int idPergunta, string perguntas, QuestionarioPerguntaEnum statusQuestionarioPergunta)
        {
            Id = id;
            IdQuestionario = idQuestionario;
            Questionario = questionario;
            IdPergunta = idPergunta;
            Perguntas = perguntas;
            StatusQuestionarioPergunta = Enum.GetName(typeof(QuestionarioPerguntaEnum), statusQuestionarioPergunta);
        }
        public int Id { get; private set; }
        public int IdQuestionario { get; private set; }
        public string Questionario { get; private set; }
        public int IdPergunta { get; private set; }
        public string Perguntas { get; private set; }
        public string StatusQuestionarioPergunta { get; private set; }
    }
}
