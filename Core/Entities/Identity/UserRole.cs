﻿using Microsoft.AspNetCore.Identity;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Identity
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public override Guid UserId { get; set; }
        public override Guid RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
