using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.Login.Models
{
    public class StudentLoginOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
    }
}
