using Prohix.Application.Services.Students.Jobs.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.UpdateUseCase
{
    public interface IJobUpdateUseCase: IScopedDependency
    {
      Task<JobUpdateOutputModel> UpdateJob(JobUpdateInputModel inputModel);  
    }
}