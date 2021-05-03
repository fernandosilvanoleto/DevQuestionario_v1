using DevQuestionario.Application.InputModels.Area;
using DevQuestionario.Application.ViewModels.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevQuestionario.Application.Services.Interfaces
{
    public interface IAreaService
    {
        List<AreaAllViewModel> GetAllArea();
        AreaByIdViewModel GetByIdArea(int id);
        int CreateArea(CreateAreaInputModel inputModel);
    }
}
