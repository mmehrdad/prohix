using Prohix.Application.Services.Students.StudentInLanguages.GetUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.GetUseCase
{
    public class StudentInLanguageGetUseCase : IStudentInLanguageGetUseCase
    {
        private readonly IStudentInLanguageRepository _studentInLanguageRepository;
        public StudentInLanguageGetUseCase(IStudentInLanguageRepository studentInLanguageRepository)
        {
            _studentInLanguageRepository = studentInLanguageRepository;
        }
        public Task<IQueryable<StudentInLanguage>> GetLanguage(Guid studentId)
        {
            var result = _studentInLanguageRepository.Get_By_StudentId(studentId);
            return result;
        }
    }
}