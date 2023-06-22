using Prohix.Core.Entities.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Proposals
{
    public class ProposalInSubject
    {
        public long ID { get; set; }
        public Subject Subject { get; set; }
        public long SubjectId { get; set; }
        public  Proposal Proposal { get; set; }
        public long ProposalID { get; set; }
    }
}
