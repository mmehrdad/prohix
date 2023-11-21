using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class Education:BaseEntity<long>
    {
        public virtual GradeOfStudy GradeOfStudy { get; set; }
        public long GradeOfStudyId { get; set; }

        public virtual University University { get; set; }
        public long UniversityId { get; set; }
        public virtual Country Country { get; set; }
        public long CountryId { get; set; }
        public virtual FieldOfStudy FieldOfStudy { get; set; }
        public long FieldOfStudyId { get; set; }

        public string Average { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
    }
}
