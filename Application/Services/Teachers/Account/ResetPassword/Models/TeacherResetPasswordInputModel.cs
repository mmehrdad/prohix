using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.ResetPassword.Models
{
    public class TeacherResetPasswordInputModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
    }
}
