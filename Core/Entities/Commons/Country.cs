using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Commons
{
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Student StudentCitizenship { get; set; }
        public Student StudentSecondCitizenship { get; set; }
        public virtual ICollection<University> Universities { get; set; }
    }
}
