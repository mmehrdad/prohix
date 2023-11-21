using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.ForgotPassword
{
    public interface ITeacherForgotPasswordUseCase : IScopedDependency
    {
        Task<DeleteOutputModel> ForgotPassword(string email);
    }
}
