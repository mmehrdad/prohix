using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.GetUseCase
{
    public interface IStudentInLanguageGetUseCase
    {
        Task<IQueryable<StudentInLanguage>> GetLanguage(Guid studentId);
    }
}