using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.DeleteUseCase
{
    public interface IUniversityDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteUniversity(int Id); 
    }
}