using Microsoft.EntityFrameworkCore;
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
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly DataBaseContext context;
        public StudentRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<Student> Get_By_StudentId(Guid studentId)
        {
            var result = GetAll().AsNoTracking().Include(p=>p.Citizenship).Include(p=>p.SecondCitizenship).FirstOrDefault(p => p.Id == studentId);
            return result;
        }
    }
}
