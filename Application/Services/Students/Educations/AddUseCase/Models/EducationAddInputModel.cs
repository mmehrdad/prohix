using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Educations.AddUseCase.Models
{
    public class EducationAddInputModel : BaseEntity<long>
    {
        public long GradeOfStudyId { get; set; }
        public long UniversityId { get; set; }
        public long CountryId { get; set; }
        public long FieldOfStudyId { get; set; }
        public string Average { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Guid StudentId { get; set; }
    }
}