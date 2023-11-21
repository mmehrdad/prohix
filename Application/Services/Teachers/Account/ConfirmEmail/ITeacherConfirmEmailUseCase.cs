using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.ConfirmEmail
{
    public interface ITeacherConfirmEmailUseCase : IScopedDependency
    {
        Task<DeleteOutputModel> ConfirmEmail(string Id, string Token);
    }
}
