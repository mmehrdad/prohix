using Prohix.Application.Services.Students.Jobs.GetUseCase;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.GetUseCase
{
    public class JobGetUseCase : IJobGetUseCase
    {
        private readonly IJobRepository _jobRepository;
        public JobGetUseCase(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public Task<IQueryable<Job>> GetJob(Guid studentId)
        {
            var result = _jobRepository.Get_By_StudentId(studentId);
            return result;
        }
    }
}