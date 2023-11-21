using Prohix.Application.Services.Teachers.TeacherInUniversities.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInUniversities.UpdateUseCase
{
    public interface ITeacherInUniversityUpdateUseCase: IScopedDependency
    {
      Task<TeacherInUniversityUpdateOutputModel> UpdateTeacherInUniversity(TeacherInUniversityUpdateInputModel inputModel);  
    }
}