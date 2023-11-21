using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.AddUseCase
{
    public interface ITeacherInSubjectAddUseCase : IScopedDependency
    {
      Task<TeacherInSubjectAddOutputModel> AddTeacherInSubject(TeacherInSubjectAddInputModel inputModel);  
    }
}