using DevQuestionario.Application.InputModels.Pergunta;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.Pergunta;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevQuestionario.Application.Services.Implementations
{
    public class PerguntaService : IPerguntaService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public PerguntaService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreatePergunta(CreatePerguntaInputModel inputModel)
        {
            var pergunta = new Pergunta(inputModel.Descricao);

            _dbContext.Perguntas.Add(pergunta);
            _dbContext.SaveChanges();

            return pergunta.Id;
        }

        public List<PerguntaViewModel> GetAllPergunta()
        {
            var perguntas = _dbContext.Perguntas;

            var perguntaViewModel = perguntas
                .Select(p => new PerguntaViewModel(p.Id, p.Descricao))
                .ToList();

            return perguntaViewModel;
        }

        public PerguntaByIdViewModel GetByIdPergunta(int id)
        {
            var pergunta = _dbContext.Perguntas.SingleOrDefault(p => p.Id == id);

            if (pergunta == null) return null;

            var perguntaByIdViewModel = new PerguntaByIdViewModel(
                    pergunta.Id,
                    pergunta.Descricao,
                    pergunta.DataCriacao
                );

            return perguntaByIdViewModel;
        }

        public int? UpdatePergunta(UpdatePerguntaInputModel inputModel)
        {
            var pergunta = _dbContext.Perguntas.SingleOrDefault(p => p.Id == inputModel.Id);

            if (pergunta == null)
            {
                return null;
            }

            pergunta.Update(inputModel.Descricao);
            _dbContext.SaveChanges();

            return pergunta.Id;
        }
    }
}
