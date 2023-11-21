using Prohix.Application.Services.Teachers.Teachers.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.UpdateUseCase
{
    public interface ITeacherUpdateUseCase: IScopedDependency
    {
      Task<TeacherUpdateOutputModel> UpdateTeacher(TeacherUpdateInputModel inputModel);  
    }
}