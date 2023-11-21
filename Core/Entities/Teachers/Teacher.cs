using Prohix.Core.Constants.Commons;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Teachers
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string CartLink { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual ICollection<TeacherInProposal> TeacherInProposals { get; set; }
        public virtual ICollection<TeacherInSubject> TeacherInSubjects { get; set; }
        public virtual ICollection<TeacherInUniversity> TeacherInUniversities { get; set; }
        public virtual ICollection<ProposalStatus> ProposalStatuses { get; set; }
        public User User { get; set; }
    }
}
