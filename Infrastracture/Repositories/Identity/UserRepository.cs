using Prohix.Core.Entities.Identity;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Identity
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly DataBaseContext context;
        public UserRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }
    }
}
