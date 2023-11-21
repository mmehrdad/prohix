using Prohix.Core.Constants.Commons;
using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class StudentInLanguage : BaseEntity<long>
    {
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
        public  Fluency Fluency { get; set; }
        public long FluancyId { get; set; }
        public virtual Language Language { get; set; }
        public long LanguageId { get; set; }
    }
}
