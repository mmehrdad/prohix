using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.TeacherInSubjects.GetUseCase
{
    public interface ITeacherInSubjectGetUseCase
    {
      IQueryable<TeacherInSubject> GetTeacherInSubject(); 
    }
}