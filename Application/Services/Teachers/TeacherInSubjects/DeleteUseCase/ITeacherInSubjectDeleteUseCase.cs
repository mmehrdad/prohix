using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.DeleteUseCase
{
    public interface ITeacherInSubjectDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeleteTeacherInSubject(int Id); 
    }
}