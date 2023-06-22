using Prohix.Core.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Teachers
{
    public class TeacherInUniversity
    {
        public long Id { get; set; }
        public University University { get; set; }
        public long UniversityId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public long TeacherId { get; set; }
    }
}
