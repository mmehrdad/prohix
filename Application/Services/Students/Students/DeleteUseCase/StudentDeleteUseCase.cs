using Prohix.Application.Services.Students.Students.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.DeleteUseCase
{
    public class StudentDeleteUseCase : IStudentDeleteUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentDeleteUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<DeleteOutputModel> DeleteStudent(Guid id)
        {
            var foundEntity = await _studentRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _studentRepository.RemoveAsync(foundEntity);
            var result = await _studentRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Student deleted successfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}