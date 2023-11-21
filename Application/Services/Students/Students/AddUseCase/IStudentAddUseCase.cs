using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Students.Students.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Students.Students.AddUseCase
{
    public interface IStudentAddUseCase : IScopedDependency
    {
      Task<StudentAddOutputModel> AddStudent(StudentAddInputModel inputModel);  
    }
}