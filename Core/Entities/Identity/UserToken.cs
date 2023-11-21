using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Identity
{
    public class UserToken : IdentityUserToken<Guid>
    {
        public User User { get; set; }
    }
}
