using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.DeleteUseCase
{
    public interface IStudentInLanguageDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteStudentInLanguage(long Id); 
    }
}