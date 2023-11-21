using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Application.Services.Teachers.Account.Register.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.Register
{
    public interface ITeacherRegisterUseCase : IScopedDependency
    {
        Task<TeacherRegisterOutputModel> RegisterTeacher(TeacherRegisterInputModel inputModel);
    }
}
