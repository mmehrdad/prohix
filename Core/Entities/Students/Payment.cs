using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class Payment:BaseEntity<int>
    {
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
        public long Amount { get; set; }
    }
}
