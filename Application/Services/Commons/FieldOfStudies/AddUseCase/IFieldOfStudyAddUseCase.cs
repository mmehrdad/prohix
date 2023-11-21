using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Commons.FieldOfStudies.AddUseCase
{
    public interface IFieldOfStudyAddUseCase : IScopedDependency
    {
      Task<FieldOfStudyAddOutputModel> AddFieldOfStudy(FieldOfStudyAddInputModel inputModel);  
    }
}