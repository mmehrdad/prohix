using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.GetUseCase
{
    public interface IJobGetUseCase
    {
        Task<IQueryable<Job>> GetJob(Guid studentId);
    }
}