using Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.UpdateUseCase
{
    public interface IGradeOfStudyUpdateUseCase: IScopedDependency
    {
      Task<GradeOfStudyUpdateOutputModel> UpdateGradeOfStudy(GradeOfStudyUpdateInputModel inputModel);  
    }
}