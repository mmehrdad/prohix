using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Proposals
{
    public class Proposal:BaseEntity<long>
    {
        public string Title { get; set; }
        public string PLink { get; set; }
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
        public ICollection<ProposalInSubject> ProposalInSubjects { get; set; }
    }
}
