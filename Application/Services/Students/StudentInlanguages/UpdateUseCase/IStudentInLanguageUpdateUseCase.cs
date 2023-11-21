using Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase
{
    public interface IStudentInLanguageUpdateUseCase: IScopedDependency
    {
      Task<StudentInLanguageUpdateOutputModel> UpdateStudentInLanguage(StudentInLanguageUpdateInputModel inputModel);  
    }
}