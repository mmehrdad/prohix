using Prohix.Application.Services.Students.Account.Register.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.Register.Models
{
    public class TeacherRegisterOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public TeacherRegisterOutputModelFields OutputModelFields { get; set; }
    }
}
