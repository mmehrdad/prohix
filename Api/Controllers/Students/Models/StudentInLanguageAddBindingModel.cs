using Prohix.Core.Constants.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Students.Models
{
    public class StudentInLanguageAddBindingModel
    {
        public long Id { get; set; }
        public Guid StudentId { get; set; }
        public Fluency Fluency { get; set; }
        public long FluancyId { get; set; }
        public long LanguageId { get; set; }
    }
}