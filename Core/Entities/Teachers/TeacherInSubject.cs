using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Core.Entities.Teachers
{
    public class TeacherInSubject
    {
        public long Id { get; set; }
        public Subject Subject { get; set; }
        public long SubjectId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public Guid TeacherId { get; set; }
    }
}
