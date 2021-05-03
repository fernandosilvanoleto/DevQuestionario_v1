using DevQuestionario.Application.InputModels.RespostaUsuario;
using DevQuestionario.Application.ViewModels.QuestionarioPergunta;
using DevQuestionario.Application.ViewModels.RespostaUsuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IRespostaUsuarioService
    {
        List<RespostaUsuarioViewModel> GetAllRespostaUsuario();
        List<GetAllRespostaUsuarioByEntrevistaViewModel> GetAllRespostaUsuarioByEntrevista(int idEntrevista);
        RespostaUsuarioByIdViewModel GetByIdRespostaUsuario(int id);
        int CreateRespostaUsuario(CreateRespostaUsuarioInputModel inputModel);
        void CargaDadosRespostaEntrevista(int idEntrevista, List<QuestionarioPerguntaByIdQuestionarioViewModel> questionarioPerguntas);
        void CreateRespostaPerguntaUsuario(CreateRespostaPerguntaUsuario inputModel);
        int RegisterRespostaUsuario(List<CreateRespostaPerguntaUsuario> respostasUsuarios);
    }
}
