using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Jobs.DeleteUseCase
{
    public interface IJobDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteJob(long Id); 
    }
}