using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Subjects.Subjects.DeleteUseCase
{
    public interface ISubjectDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteSubject(int Id); 
    }
}