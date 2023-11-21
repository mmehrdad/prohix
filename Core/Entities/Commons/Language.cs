using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Commons
{
    public class Language
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public virtual ICollection<StudentInLanguage> StudentInLanguages { get; set; }

    }
}
