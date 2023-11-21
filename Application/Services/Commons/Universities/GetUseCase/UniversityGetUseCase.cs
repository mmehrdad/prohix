using Prohix.Application.Services.Commons.GradeOfStudies.GetUseCase;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.GetUseCase
{
    public class UniversityGetUseCase : IUniversityGetUseCase
    {
        private readonly IUniversityRepository _universityRepository;
        public UniversityGetUseCase(IUniversityRepository universityRepository)
        {
            _universityRepository = universityRepository;
        }
        public async Task< IQueryable<University>> GetUniversity(long countryId)
        {
            var result = _universityRepository.Get_By_CountryId(countryId).Result;

            return result;
        }
    }
}