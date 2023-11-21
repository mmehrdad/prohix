using Prohix.Application.Services.Commons.Countries.GetUseCase;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.FieldOfStudies.GetUseCase
{
    public class FieldOfStudyGetUseCase : IFieldOfStudyGetUseCase
    {
        private readonly IFieldOfStudyRepository _fieldOfStudyRepository;
        public FieldOfStudyGetUseCase(IFieldOfStudyRepository fieldOfStudyRepository)
        {
            _fieldOfStudyRepository = fieldOfStudyRepository;
        }
        public async Task< IQueryable<FieldOfStudy>> GetFieldOfStudy()
        {
            var result = _fieldOfStudyRepository.GetAllAsNoTracking();
            return result;
        }
    }
}