using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class Job:BaseEntity<int>
    {
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Institute { get; set; }
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
    }
}
