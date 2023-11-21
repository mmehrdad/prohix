using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Teachers.Account.Register.Models
{
    public class TeacherRegisterOutputModelFields
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsRemoved { get; set; }
        public bool IsActive { get; set; }
    }
}
