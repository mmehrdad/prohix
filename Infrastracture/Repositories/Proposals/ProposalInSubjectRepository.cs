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
    public class ProposalInSubjectRepository : BaseRepository<ProposalInSubject>, IProposalInSubjectRepository
    {
        private readonly DataBaseContext context;
        public ProposalInSubjectRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }


    }
}
