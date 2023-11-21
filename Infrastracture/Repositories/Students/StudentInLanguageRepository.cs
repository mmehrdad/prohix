using Prohix.Core.Entities.Commons;
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
    public class StudentInLanguageRepository : BaseRepository<StudentInLanguage>, IStudentInLanguageRepository
    {
        private readonly DataBaseContext context;
        public StudentInLanguageRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IQueryable<StudentInLanguage>> Get_By_StudentId(Guid studentId)
        {
            var result = GetAll().Where(p => p.StudentId == studentId);
            return result;
        }
    }
}
