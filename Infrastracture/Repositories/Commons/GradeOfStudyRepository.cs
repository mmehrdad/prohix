using Prohix.Core.Entities.Commons;
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
    public class GradeOfStudyRepository : BaseRepository<GradeOfStudy>, IGradeOfStudyRepository
    {
        private readonly DataBaseContext context;
        public GradeOfStudyRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

    }
}
