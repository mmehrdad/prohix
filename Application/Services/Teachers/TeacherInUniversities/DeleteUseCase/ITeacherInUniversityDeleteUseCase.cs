using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInUniversities.DeleteUseCase
{
    public interface ITeacherInUniversityDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteTeacherInUniversity(int Id); 
    }
}