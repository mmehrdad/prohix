using Microsoft.AspNetCore.Identity;
using Samak.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Identity
{
    public class Role : IdentityRole<int>
    {
        public string Name { get; set; }
        public ICollection<UserRole> Users { get; set; }
    }
}
