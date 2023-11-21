using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Commons.Universities.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Commons.Universities.AddUseCase
{
    public interface IUniversityAddUseCase : IScopedDependency
    {
      Task<UniversityAddOutputModel> AddUniversity(UniversityAddInputModel inputModel);  
    }
}