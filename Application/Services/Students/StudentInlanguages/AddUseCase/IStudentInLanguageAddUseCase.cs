using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Students.StudentInLanguages.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Students.StudentInLanguages.AddUseCase
{
    public interface IStudentInLanguageAddUseCase : IScopedDependency
    {
      Task<StudentInLanguageAddOutputModel> AddStudentInLanguage(StudentInLanguageAddInputModel inputModel);  
    }
}