using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.DeleteUseCase
{
    public interface ITeacherDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteTeacher(int Id); 
    }
}