using Microsoft.AspNetCore.Identity;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samak.Domain.Entities.Identity
{
    public class UserRole : IdentityUserRole<int>
    {
        public  int StudentId { get; set; }
        public  int RoleId { get; set; }
        public Student User { get; set; }
        public Role Role { get; set; }
    }
}
