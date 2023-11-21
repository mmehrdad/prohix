using Prohix.Application.Services.Commons.Universities.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.UpdateUseCase
{
    public interface IUniversityUpdateUseCase: IScopedDependency
    {
      Task<UniversityUpdateOutputModel> UpdateUniversity(UniversityUpdateInputModel inputModel);  
    }
}