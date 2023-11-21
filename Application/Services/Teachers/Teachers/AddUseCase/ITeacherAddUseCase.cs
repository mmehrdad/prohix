using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Teachers.Teachers.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Teachers.Teachers.AddUseCase
{
    public interface ITeacherAddUseCase : IScopedDependency
    {
      Task<TeacherAddOutputModel> AddTeacher(TeacherAddInputModel inputModel);  
    }
}