using Prohix.Application.Services.Students.Students.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.UpdateUseCase
{
    public interface IStudentUpdateUseCase: IScopedDependency
    {
      Task<StudentUpdateOutputModel> UpdateStudent(StudentUpdateInputModel inputModel);  
    }
}