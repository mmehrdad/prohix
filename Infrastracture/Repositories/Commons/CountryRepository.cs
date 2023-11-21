using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Proposals;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Commons
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly DataBaseContext context;
        public CountryRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }


    }
}
