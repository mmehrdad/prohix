using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.ConfirmEmail
{
    public interface IStudentConfirmEmailUseCase : IScopedDependency
    {
        Task<DeleteOutputModel> ConfirmEmail(string Id,string Token);
    }
}
