using Prohix.Application.Services.Students.Jobs.DeleteUseCase;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.DeleteUseCase
{
    public class JobDeleteUseCase : IJobDeleteUseCase
    {
        private readonly IJobRepository _jobRepository;

        public JobDeleteUseCase(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<DeleteOutputModel> DeleteJob(long id)
        {
            var foundEntity = await _jobRepository.FindAsync(id);
            if (foundEntity == null)
                return new DeleteOutputModel() { HasError = true, Message = "No data found !!" };

            await _jobRepository.RemoveAsync(foundEntity);
            var result = await _jobRepository.SaveChangesAsync();

            return result > 0 ? new DeleteOutputModel { HasError = false, Message = "Job deleted successfully" } :
                                new DeleteOutputModel { HasError = true, Message = "Somthing went wrong !!" };
        }
    }
}