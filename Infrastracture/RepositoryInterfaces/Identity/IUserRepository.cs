using Prohix.Core.Entities.Identity;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.RepositoryInterfaces.Identity
{
    public interface IUserRepository : IBaseRepository<User>, IScopedDependency
    {
        
    }
}
