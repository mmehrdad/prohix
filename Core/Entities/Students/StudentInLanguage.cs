using Prohix.Core.Entities.Commons;
using Studex.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Students
{
    public class StudentInLanguage
    {
        public long ID { get; set; }
        public virtual Student Student { get; set; }
        public Guid StID { get; set; }
        public  Fluency Fluency { get; set; }
        public long FluancyID { get; set; }
        public virtual Language Language { get; set; }
        public long LanguageID { get; set; }
    }
}
