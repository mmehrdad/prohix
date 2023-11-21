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
    public class TeacherInUniversityRepository : BaseRepository<TeacherInUniversity>, ITeacherInUniversityRepository
    {
        private readonly DataBaseContext context;
        public TeacherInUniversityRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

    }
}
