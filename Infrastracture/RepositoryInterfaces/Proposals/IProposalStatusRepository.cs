using Prohix.Core.Entities.Proposals;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.RepositoryInterfaces.Proposals
{
    public interface IProposalStatusRepository : IBaseRepository<ProposalStatus>, IScopedDependency
    {
    }
}
