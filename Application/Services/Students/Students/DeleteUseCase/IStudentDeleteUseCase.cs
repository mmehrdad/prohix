using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.DeleteUseCase
{
    public interface IStudentDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteStudent(Guid Id); 
    }
}