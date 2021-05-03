using DevQuestionario.Application.InputModels.RespostaUsuario;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.QuestionarioPergunta;
using DevQuestionario.Application.ViewModels.RespostaUsuario;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevQuestionario.Application.Services.Implementations
{
    public class RespostaUsuarioService : IRespostaUsuarioService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public RespostaUsuarioService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CargaDadosRespostaEntrevista(int idEntrevista, List<QuestionarioPerguntaByIdQuestionarioViewModel> questionarioPerguntas)
        {
            foreach (var item in questionarioPerguntas)
            {
                var respostausuario = new RespostaUsuario(idEntrevista, item.IdPergunta);
                _dbContext.RespostaUsuarios.Add(respostausuario);
            }
            _dbContext.SaveChanges();
        }

        public void CreateRespostaPerguntaUsuario(CreateRespostaPerguntaUsuario inputModel)
        {
            throw new NotImplementedException();

            // xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        }

        public int CreateRespostaUsuario(CreateRespostaUsuarioInputModel inputModel)
        {
            var respostausuario = new RespostaUsuario(inputModel.IdEntrevista, inputModel.IdPergunta);

            _dbContext.RespostaUsuarios.Add(respostausuario);
            _dbContext.SaveChanges();

            return respostausuario.Id;
        }

        public List<RespostaUsuarioViewModel> GetAllRespostaUsuario()
        {
            var respostausuarios = _dbContext.RespostaUsuarios;

            var respostaUsuarioViewModel = respostausuarios
                .Include(e => e.Entrevista)
                .Include(p => p.Perguntas)
                .Include(a => a.Area)
                //.Include(c => c.Entrevista.Entrevistado)
                .Select(ruser => new RespostaUsuarioViewModel(ruser.Id, ruser.IdEntrevista, ruser.IdPergunta, ruser.Perguntas.Descricao, ruser.IdArea, ruser.Area.Descricao, ruser.Resposta))
                .ToList();

            return respostaUsuarioViewModel;
        }

        public List<GetAllRespostaUsuarioByEntrevistaViewModel> GetAllRespostaUsuarioByEntrevista(int idEntrevista)
        {
            var respostausuarios = _dbContext.RespostaUsuarios;

            var respostaUsuarioViewModel = respostausuarios
                .Include(e => e.Entrevista)
                .Include(p => p.Perguntas)
                .Include(a => a.Area)
                .Where(ruser => ruser.IdEntrevista == idEntrevista)
                //.Include(c => c.Entrevista.Entrevistado)
                .Select(ruser => new GetAllRespostaUsuarioByEntrevistaViewModel(ruser.Id, ruser.IdPergunta, ruser.Perguntas.Descricao, ruser.IdEntrevista, ruser.Resposta, ruser.DataHoraResposta, ruser.Localizacao))
                .ToList();

            return respostaUsuarioViewModel;

        }

        public RespostaUsuarioByIdViewModel GetByIdRespostaUsuario(int id)
        {
            var respostausuario = _dbContext.RespostaUsuarios
                .Include(e => e.Entrevista)
                .Include(p => p.Perguntas)
                .Include(a => a.Area)
                .SingleOrDefault(r => r.Id == id);

            if (respostausuario == null) return null;

            var respostaUsuarioByIdViewModel = new RespostaUsuarioByIdViewModel(
                    respostausuario.Id,
                    respostausuario.IdEntrevista,
                    respostausuario.IdPergunta,
                    respostausuario.Perguntas.Descricao,
                    respostausuario.IdArea,
                    respostausuario.Area.Descricao,
                    respostausuario.Resposta,
                    respostausuario.DataHoraResposta
                );

            return respostaUsuarioByIdViewModel;
        }

        public int RegisterRespostaUsuario(List<CreateRespostaPerguntaUsuario> respostasUsuarios)
        {
            var idEntrevista = 0;

            foreach (var item in respostasUsuarios)
            {
                var respostausuarioById = _dbContext.RespostaUsuarios
                .SingleOrDefault(r => r.Id == item.IdResposta && r.IdEntrevista == item.IdEntrevista && r.IdPergunta == item.IdPergunta);

                // ALTERAR RESPOSTA DE USUÁRIO
                respostausuarioById.RespostaPergunta(item.Resposta, item.LocalizacaoAtual);

                idEntrevista = item.IdEntrevista;
            }
            _dbContext.SaveChanges();

            return idEntrevista;
        }
    }
}
