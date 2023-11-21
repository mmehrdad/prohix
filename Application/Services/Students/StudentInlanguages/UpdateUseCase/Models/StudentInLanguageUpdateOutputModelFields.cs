using Prohix.Core.Constants.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.StudentInLanguages.UpdateUseCase.Models
{
    public class StudentInLanguageUpdateOutputModelFields
    {
        public long Id { get; set; }
        public Guid StudentId { get; set; }
        public Fluency Fluency { get; set; }
        public long FluancyId { get; set; }
        public long LanguageId { get; set; }
    }
}