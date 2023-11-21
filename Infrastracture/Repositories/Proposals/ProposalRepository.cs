using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Proposals
{
    public class ProposalRepository : BaseRepository<Proposal>, IProposalRepository
    {
        private readonly DataBaseContext context;
        public ProposalRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IQueryable<Proposal>> Get_By_StudentId(Guid studentId)
        {
            var result = GetAll().Where(p => p.StudentId == studentId);
            return result;
        }

        public async Task<IQueryable<Proposal>> Get_By_TeacherId(Guid teacherId)
        {
            var result = GetAll().Include(p=>p.TeacherInProposals.Where(n=>n.TeacherId==teacherId)).ThenInclude(p=>p.Proposal).ThenInclude(p=>p.Student);
           
            return result;
        }
        public async Task<IQueryable<Proposal>> Get_By_SubjectId(long subjectId)
        {
            var result = GetAll().Include(p => p.ProposalInSubjects.Where(n => n.SubjectId == subjectId)).ThenInclude(p => p.Proposal).ThenInclude(p => p.Student);

            return result;
        }
    }
}
