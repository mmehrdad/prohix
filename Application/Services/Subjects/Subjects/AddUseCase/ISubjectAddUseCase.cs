using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Subjects.Subjects.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Subjects.Subjects.AddUseCase
{
    public interface ISubjectAddUseCase : IScopedDependency
    {
      Task<SubjectAddOutputModel> AddSubject(SubjectAddInputModel inputModel);  
    }
}