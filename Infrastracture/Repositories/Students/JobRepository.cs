using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Students
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        private readonly DataBaseContext context;
        public JobRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IQueryable<Job>> Get_By_StudentId(Guid studentId)
        {
            var result = GetAll().Where(p => p.StudentId == studentId);
            return result;
        }
    }
}
