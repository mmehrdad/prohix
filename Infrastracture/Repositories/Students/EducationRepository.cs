using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Proposals;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Students
{
    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        private readonly DataBaseContext context;
        public EducationRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IQueryable<Education>> Get_By_StudentId(Guid studentId)
        {
            var result = GetAll().AsNoTracking()
                .Include(p => p.Country)
                .Include(p => p.University)
                .Include(p => p.FieldOfStudy)
                .Include(p => p.GradeOfStudy)
                .Where(p => p.StudentId == studentId);
            return result;
        }
    }
}
