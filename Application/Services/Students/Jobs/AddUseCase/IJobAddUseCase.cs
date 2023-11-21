using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Students.Jobs.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Students.Jobs.AddUseCase
{
    public interface IJobAddUseCase : IScopedDependency
    {
      Task<JobAddOutputModel> AddJob(JobAddInputModel inputModel);  
    }
}