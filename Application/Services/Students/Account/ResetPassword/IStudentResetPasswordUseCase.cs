using Prohix.Application.Services.Students.Account.ResetPassword.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.ResetPassword
{
    public interface IStudentResetPasswordUseCase : IScopedDependency
    {
        Task<DeleteOutputModel> ResetPassword( StudentResetPasswordInputModel inputModel);
    }
}
