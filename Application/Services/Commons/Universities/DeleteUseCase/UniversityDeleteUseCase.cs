using Prohix.Application.Services.Commons.Countries.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.DeleteUseCase
{
    public class UniversityDeleteUseCase : IUniversityDeleteUseCase
    {
        private readonly IUniversityRepository _universityRepository;

        public UniversityDeleteUseCase(IUniversityRepository universityRepository)
        {
            _universityRepository = universityRepository;
        }

        public async Task<DeleteOutputModel> DeleteUniversity(int id)
        {
            var foundEntity = await _universityRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _universityRepository.RemoveAsync(foundEntity);
            var result = await _universityRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "University deleted sucessfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}