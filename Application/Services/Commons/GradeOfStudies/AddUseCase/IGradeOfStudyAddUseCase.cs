using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Commons.GradeOfStudies.AddUseCase
{
    public interface IGradeOfStudyAddUseCase : IScopedDependency
    {
      Task<GradeOfStudyAddOutputModel> AddGradeOfStudy(GradeOfStudyAddInputModel inputModel);  
    }
}