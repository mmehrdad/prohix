using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Students.GetUseCase
{
    public interface IStudentGetUseCase
    {
      IQueryable<Student> GetStudent();
       Task<Student> Get_Student_By_Id(Guid Id);
    }
}