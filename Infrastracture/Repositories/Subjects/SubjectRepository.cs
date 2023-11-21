using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Subjects;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Subjects
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly DataBaseContext context;
        public SubjectRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

    }
}
