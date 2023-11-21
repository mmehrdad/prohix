using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Application.Services.Students.Account.Register.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Publics.EmailService
{
    public interface IEmailService : IScopedDependency
    {
       Task< Task> SendEmail(EmailServiceInputModel inputModel);
    }
}
