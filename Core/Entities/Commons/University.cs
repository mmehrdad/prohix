using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Commons
{
    public class University
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<University> Universities { get; set; }
    }
}
