using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Commons
{
    public class University
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public long CountryId { get; set; }
        public bool IsValid { get; set; }
        public virtual ICollection<TeacherInUniversity> TeacherInUniversities { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
    }
}
