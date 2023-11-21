using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Teachers.GetUseCase
{
    public interface ITeacherGetUseCase
    {
      IQueryable<Teacher> GetTeacher(); 
    }
}