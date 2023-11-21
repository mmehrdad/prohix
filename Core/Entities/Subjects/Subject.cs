using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Subjects
{
    public class Subject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProposalInSubject> ProposalInSubjects { get; set; }
        public ICollection<TeacherInSubject> TeacherInSubjects { get; set; }
    }
}
