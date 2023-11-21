using Prohix.Application.Services.Teachers.TeacherInSubjects.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.UpdateUseCase
{
    public interface ITeacherInSubjectUpdateUseCase: IScopedDependency
    {
        Task<TeacherInSubjectUpdateOutputModel> UpdateTeacherInSubject(TeacherInSubjectUpdateInputModel inputModel); 
    }
}