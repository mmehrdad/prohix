using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Teachers;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Teachers
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        private readonly DataBaseContext context;
        public TeacherRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<IQueryable<Teacher>> Get_By_ProposalId(long proposalId)
        {
            var result = GetAll().Include(p => p.TeacherInProposals.Where(n => n.ProposalId == proposalId)).ThenInclude(p => p.Teacher);

            return result;
        }

    }
}
