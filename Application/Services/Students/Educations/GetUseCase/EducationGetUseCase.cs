using Prohix.Application.Services.Commons.Countries.GetUseCase;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.RepositoryInterfaces.Commons;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.GetUseCase
{
    public class EducationGetUseCase : IEducationGetUseCase
    {
        private readonly IEducationRepository _educationRepository;
        public EducationGetUseCase(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }
        public Task< IQueryable<Education>> GetEducation(Guid studentId)
        {
            var result = _educationRepository.Get_By_StudentId(studentId);
            return result;
        }
    }
}