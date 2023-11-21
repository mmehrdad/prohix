using Prohix.Application.Services.Subjects.Subjects.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Subjects.Subjects.UpdateUseCase
{
    public interface ISubjectUpdateUseCase: IScopedDependency
    {
      Task<SubjectUpdateOutputModel> UpdateSubject(SubjectUpdateInputModel inputModel);  
    }
}