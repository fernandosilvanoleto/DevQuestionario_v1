using DevQuestionario.Application.InputModels.Questionario;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.Questionario;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevQuestionario.Application.Services.Implementations
{
    public class QuestionarioService : IQuestionarioService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public QuestionarioService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateQuestionario(CreateQuestionarioInputModel inputModel)
        {
            var questionario = new Questionario(inputModel.IdCriadorUsuario, inputModel.Titulo, inputModel.Descricao);

            _dbContext.Questionarios.Add(questionario);
            _dbContext.SaveChanges();

            return questionario.Id;
        }

        public List<QuestionarioViewModel> GetAllQuestionario()
        {
            var questionarios = _dbContext.Questionarios;

            var questionarioViewModel = questionarios
                .Include(q => q.CriadorUsuario)
                .Where(q => q.StatusQuestionario == Core.Enum.QuestionarioEnum.Ativo)
                .Select(q => new QuestionarioViewModel(q.Id, q.CriadorUsuario.Nome, q.Titulo, q.Descricao, q.StatusQuestionario))
                .ToList();

            return questionarioViewModel;
        }

        public QuestionarioByIdViewModel GetByIdQuestionario(int id)
        {
            var questionario = _dbContext.Questionarios
                .Include(q => q.CriadorUsuario)
                .SingleOrDefault(q => q.Id == id);

            if (questionario == null)
            {
                return null;
            }

            var questionarioByIdViewModel = new QuestionarioByIdViewModel(
                    questionario.Id,
                    questionario.CriadorUsuario.Nome,
                    questionario.Titulo,
                    questionario.Descricao,
                    questionario.StatusQuestionario,
                    questionario.DataCriacao
                );

            return questionarioByIdViewModel;
        }

        public List<QuestionarioByIdViewModel> GetByIdQuestionarioByCliente(int idCriador)
        {

            var questionarios = _dbContext.Questionarios;

            var questionarioByIdViewModel = questionarios
                .Include(q => q.CriadorUsuario)
                .Where(q => q.IdCriadorUsuario == idCriador)
                .Select(q => new QuestionarioByIdViewModel(q.Id, q.CriadorUsuario.Nome, q.Titulo, q.Descricao, q.StatusQuestionario, q.DataCriacao))
                .ToList();

            return questionarioByIdViewModel;
        }

        public int? RecuperarQuestionario(int id)
        {
            var questionario = _dbContext.Questionarios.SingleOrDefault(q => q.Id == id);

            if (questionario == null)
            {
                return null;
            }

            questionario.Recuperar();
            _dbContext.SaveChanges();

            return questionario.Id;
        }

        public int? RemoverQuestionario(int id)
        {
            var questionario = _dbContext.Questionarios.SingleOrDefault(q => q.Id == id);

            if (questionario == null)
            {
                return null;
            }

            questionario.Remover();
            _dbContext.SaveChanges();

            return questionario.Id;
        }

        public int? UpdateQuestionario(UpdateQuestionarioInputModel inputModel)
        {
            var questionario = _dbContext.Questionarios.SingleOrDefault(q => q.Id == inputModel.Id);

            if (questionario == null)
            {
                return null;
            }

            questionario.Update(inputModel.Titulo, inputModel.Descricao);
            _dbContext.SaveChanges();

            return questionario.Id;
        }
    }
}
