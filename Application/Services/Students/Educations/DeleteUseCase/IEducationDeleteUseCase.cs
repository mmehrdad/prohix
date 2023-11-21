using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.DeleteUseCase
{
    public interface IEducationDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteEducation(long Id); 
    }
}