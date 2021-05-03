using DevQuestionario.Application.InputModels.QuestionarioPerrgunta;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.QuestionarioPergunta;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevQuestionario.Application.Services.Implementations
{
    public class QuestionarioPerguntaService : IQuestionarioPerguntaService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public QuestionarioPerguntaService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateQuestionarioPergunta(CreateQuestionarioPerguntaInputModel inputModel)
        {
            var questionariopergunta = new QuestionarioPergunta(inputModel.IdQuestionario, inputModel.IdPergunta);

            _dbContext.QuestionarioPerguntas.Add(questionariopergunta);
            _dbContext.SaveChanges();

            return questionariopergunta.Id;
        }

        public List<QuestionarioPerguntaViewModel> GetAllQuestionarioPergunta()
        {
            var questionarioPerguntas = _dbContext.QuestionarioPerguntas;

            var questionarioPerguntaViewModel = questionarioPerguntas
                .Include(q => q.Questionario)
                .Include(p => p.Perguntas)
                .Select(qp => new QuestionarioPerguntaViewModel(qp.Id, qp.IdQuestionario, qp.Questionario.Titulo, qp.IdPergunta, qp.Perguntas.Descricao, qp.StatusQuestionarioPergunta))
                //.Where(qp => qp.StatusQuestionarioPergunta == "Ativo")
                .ToList();

            return questionarioPerguntaViewModel;
        }

        public QuestionarioPerguntaByIdViewModel GetByIdQuestionarioPergunta(int id)
        {
            var questionariopergunta = _dbContext.QuestionarioPerguntas
                .Include(q => q.Questionario)
                .Include(p => p.Perguntas)
                .SingleOrDefault(qp => qp.Id == id);

            if (questionariopergunta == null) return null;

            var questionarioPerguntaByIdViewModel = new QuestionarioPerguntaByIdViewModel(
                    questionariopergunta.Id,
                    questionariopergunta.IdQuestionario,
                    questionariopergunta.Questionario.Descricao,
                    questionariopergunta.IdPergunta,
                    questionariopergunta.Perguntas.Descricao,
                    questionariopergunta.StatusQuestionarioPergunta,
                    questionariopergunta.DataCriacao
                );

            return questionarioPerguntaByIdViewModel;
        }

        public List<QuestionarioPerguntaByIdQuestionarioViewModel> GetByIdQuestionarioPerguntaByIdQuestionario(int IdQuestionario)
        {
            var questionarioPerguntas = _dbContext.QuestionarioPerguntas;

            var questionarioPerguntaByIdQuestionarioViewModel = questionarioPerguntas
                .Include(q => q.Questionario)
                .Include(p => p.Perguntas)
                .Include(ques_cliente => ques_cliente.Questionario.CriadorUsuario)
                .Where(qp => qp.IdQuestionario == IdQuestionario)
                .Select(qp => new QuestionarioPerguntaByIdQuestionarioViewModel(
                    qp.Id,
                    qp.Questionario.CriadorUsuario.Id,
                    qp.Questionario.CriadorUsuario.Nome,
                    qp.IdQuestionario, 
                    qp.Questionario.Titulo, 
                    qp.IdPergunta, 
                    qp.Perguntas.Descricao, 
                    qp.StatusQuestionarioPergunta,
                    qp.DataCriacao))
                //.Where(qp => qp.StatusQuestionarioPergunta == "Ativo")
                .ToList();

            return questionarioPerguntaByIdQuestionarioViewModel;
        }

        public int? InativarQuestionarioPergunta(int id)
        {
            var questionarioPergunta = _dbContext.QuestionarioPerguntas.SingleOrDefault(q => q.Id == id);

            if (questionarioPergunta == null)
            {
                return null;
            }

            questionarioPergunta.Inativar();
            _dbContext.SaveChanges();

            return questionarioPergunta.Id;
        }

        public int? ReativarQuestionarioPergunta(int id)
        {
            var questionarioPergunta = _dbContext.QuestionarioPerguntas.SingleOrDefault(q => q.Id == id);

            if (questionarioPergunta == null)
            {
                return null;
            }

            questionarioPergunta.Reativar();
            _dbContext.SaveChanges();

            return questionarioPergunta.Id;
        }
    }
}
