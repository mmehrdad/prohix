using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.FieldOfStudies.DeleteUseCase
{
    public class FieldOfStudyDeleteUseCase : IFieldOfStudyDeleteUseCase
    {
        private readonly IFieldOfStudyRepository _fieldOfStudyRepository;

        public FieldOfStudyDeleteUseCase(IFieldOfStudyRepository fieldOfStudyRepository)
        {
            _fieldOfStudyRepository = fieldOfStudyRepository;
        }

        public async Task<DeleteOutputModel> DeleteFieldOfStudy(int id)
        {
            var foundEntity = await _fieldOfStudyRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _fieldOfStudyRepository.RemoveAsync(foundEntity);
            var result = await _fieldOfStudyRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Field of study deleted sucessfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}