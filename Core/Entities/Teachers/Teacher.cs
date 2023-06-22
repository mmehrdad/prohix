using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Teachers
{
    public class Teacher:Student
    {
        public string Password { get; set; }
        public string CartLink { get; set; }
        public virtual ICollection<TeacherInProposal> TeacherInProposals { get; set; }
        public virtual ICollection<TeacherInSubject> TeacherInSubjects { get; set; }
        public virtual ICollection<TeacherInUniversity> TeacherInUniversities { get; set; }
    }
}
