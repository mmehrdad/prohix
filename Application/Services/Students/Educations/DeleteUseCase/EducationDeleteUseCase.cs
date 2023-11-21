using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.DeleteUseCase
{
    public class EducationDeleteUseCase : IEducationDeleteUseCase
    {
        private readonly IEducationRepository _educationRepository;

        public EducationDeleteUseCase(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public async Task<DeleteOutputModel> DeleteEducation(long id)
        {
            var foundEntity = await _educationRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _educationRepository.RemoveAsync(foundEntity);
            var result = await _educationRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Education deleted successfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}