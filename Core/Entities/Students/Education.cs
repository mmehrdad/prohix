using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class Education:BaseEntity<int>
    {
        public virtual GradeOfStudy GradeOfStudy { get; set; }
        public long GradeOfStudyID { get; set; }

        public virtual University University { get; set; }
        public long UniversityID { get; set; }

        public virtual Country Country { get; set; }
        public long CountryID { get; set; }

        public virtual FieldOfStudy FieldOfStudy { get; set; }
        public long FieldOfStudyID { get; set; }


        public string Average { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public virtual Student Student { get; set; }
        public Guid StID { get; set; }
    }
}
