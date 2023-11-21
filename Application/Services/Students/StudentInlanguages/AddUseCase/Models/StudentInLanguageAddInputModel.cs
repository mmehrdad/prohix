using Prohix.Core.Constants.Commons;
using Prohix.Core.Entities.Commons;
using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.AddUseCase.Models
{
    public class StudentInLanguageAddInputModel : BaseEntity<long>
    {
        public Guid StudentId { get; set; }
        public Fluency Fluency { get; set; }
        public long FluancyId { get; set; }
        public long LanguageId { get; set; }
    }
}