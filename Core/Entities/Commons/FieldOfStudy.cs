using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Commons
{
    public class FieldOfStudy
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
    }
}
