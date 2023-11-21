using Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.FieldOfStudies.UpdateUseCase
{
    public interface IFieldOfStudyUpdateUseCase: IScopedDependency
    {
      Task<FieldOfStudyUpdateOutputModel> UpdateFieldOfStudy(FieldOfStudyUpdateInputModel inputModel);  
    }
}