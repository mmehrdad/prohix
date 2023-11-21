using Prohix.Application.Services.Students.StudentInLanguages.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.DeleteUseCase
{
    public class StudentInLanguageDeleteUseCase : IStudentInLanguageDeleteUseCase
    {
        private readonly IStudentInLanguageRepository _studentInLanguageRepository;

        public StudentInLanguageDeleteUseCase(IStudentInLanguageRepository studentInLanguageRepository)
        {
            _studentInLanguageRepository = studentInLanguageRepository;
        }

        public async Task<DeleteOutputModel> DeleteStudentInLanguage(long id)
        {
            var foundEntity = await _studentInLanguageRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _studentInLanguageRepository.RemoveAsync(foundEntity);
            var result = await _studentInLanguageRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Data deleted successfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}