using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Teachers.Models
{
    public class TeacherInUniversityAddBindingModel
    {
        public long Id { get; set; }
        public long UniversityId { get; set; }
        public Guid TeacherId { get; set; }
    }
}