using DevQuestionario.Application.InputModels.Area;
using DevQuestionario.Application.Services.Interfaces;
using DevQuestionario.Application.ViewModels.Area;
using DevQuestionario.Core.Entities;
using DevQuestionario.Infrastrucutre.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevQuestionario.Application.Services.Implementations
{
    public class AreaService : IAreaService
    {
        private readonly DevQuestionarioDbContext _dbContext;
        public AreaService(DevQuestionarioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateArea(CreateAreaInputModel inputModel)
        {
            var area = new Area(inputModel.Descricao, inputModel.Observacao);

            _dbContext.Areas.Add(area);
            _dbContext.SaveChanges();

            return area.Id;
        }

        public List<AreaAllViewModel> GetAllArea()
        {
            var areas = _dbContext.Areas;

            var areaAllViewModel = areas
                .Select(a => new AreaAllViewModel(a.Id, a.Descricao))
                .ToList();

            return areaAllViewModel;
        }

        public AreaByIdViewModel GetByIdArea(int id)
        {
            var area = _dbContext.Areas.SingleOrDefault(a => a.Id == id);

            if (area == null) return null;

            var areaByIdViewModel = new AreaByIdViewModel(
                    area.Id,
                    area.Descricao,
                    area.Observacao
                );

            return areaByIdViewModel;

        }
    }
}
