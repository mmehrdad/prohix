using Prohix.Application.Services.Commons.Countries.GetUseCase;
using Prohix.Core.Entities.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.GradeOfStudies.GetUseCase
{
    public class GradeOfStudyGetUseCase : IGradeOfStudyGetUseCase
    {
        private readonly IGradeOfStudyRepository _gradeOfStudyRepository;
        public GradeOfStudyGetUseCase(IGradeOfStudyRepository gradeOfStudyRepository)
        {
            _gradeOfStudyRepository = gradeOfStudyRepository;
        }
        public IQueryable<GradeOfStudy> GetGradeOfStudy()
        {
            var result = _gradeOfStudyRepository.GetAllAsNoTracking();
            return result;
        }
    }
}