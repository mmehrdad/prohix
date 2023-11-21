using Microsoft.AspNetCore.Identity;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Identity
{
    public class User : IdentityUser<Guid>
    {
        public bool? IsActive { get; set; }
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }
        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public DateTime? CreatedTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedDateTime { get; set; }
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemovedDateTime { get; set; }
        public ICollection<UserToken> UserTokens { get; set; }

        public ICollection<UserRole> Roles { get; set; }

        public ICollection<UserLogin> Logins { get; set; }

        public ICollection<UserClaim> Claims { get; set; }
    }
}
