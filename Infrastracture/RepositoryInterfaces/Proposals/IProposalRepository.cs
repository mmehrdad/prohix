using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.RepositoryInterfaces.Proposals
{
    public interface IProposalRepository : IBaseRepository<Proposal>, IScopedDependency
    {
        public Task<IQueryable<Proposal>> Get_By_StudentId(Guid studentId);
        public Task<IQueryable<Proposal>> Get_By_TeacherId(Guid teacherId);
    }
}
