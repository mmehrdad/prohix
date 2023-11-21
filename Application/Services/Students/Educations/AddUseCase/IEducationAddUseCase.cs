using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Students.Educations.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Students.Educations.AddUseCase
{
    public interface IEducationAddUseCase : IScopedDependency
    {
      Task<EducationAddOutputModel> AddEducation(EducationAddInputModel inputModel);  
    }
}