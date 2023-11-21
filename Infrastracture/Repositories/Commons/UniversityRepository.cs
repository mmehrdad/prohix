using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Teachers;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Commons
{
    public class UniversityRepository : BaseRepository<University>, IUniversityRepository
    {
        private readonly DataBaseContext context;
        public UniversityRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<IQueryable<University>> Get_By_TeacherId(Guid teacherId)
        {
            var result = GetAll().Include(p => p.TeacherInUniversities.Where(n => n.TeacherId == teacherId)).ThenInclude(p => p.University);

            return result;
        }
        public async Task<IQueryable<University>> Get_By_CountryId(long countryId)
        {
            var result = GetAll().Where(p=>p.CountryId==countryId && p.IsValid==true);

            return result;
        }

    }
}
