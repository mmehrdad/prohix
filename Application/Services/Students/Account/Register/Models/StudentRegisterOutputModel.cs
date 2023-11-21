using Prohix.Application.Services.Students.Students.AddUseCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.Register.Models
{
    public class StudentRegisterOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public StudentRegisterOutputModelFields OutputModelFields { get; set; }
    }
}
