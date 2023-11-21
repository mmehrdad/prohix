using Prohix.Core.Entities.Proposals;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Proposals
{
    public class ProposalStatusRepository : BaseRepository<ProposalStatus>, IProposalStatusRepository
    {
        private readonly DataBaseContext context;
        public ProposalStatusRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }


    }
}
