using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Account.Register.Models
{
    public class StudentRegisterInputModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsRemoved { get; set; } = false;
        public bool IsActive { get; set; } = false;
    }
}
