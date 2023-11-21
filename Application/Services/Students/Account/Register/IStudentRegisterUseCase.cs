using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Application.Services.Students.Students.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.Register
{
    public interface IStudentRegisterUseCase : IScopedDependency
    {
        Task<StudentRegisterOutputModel> RegisterStudent(StudentRegisterInputModel inputModel);
    }
}
