using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Commons.Models
{
    public class UniversityAddBindingModel
    {
        public string Name { get; set; }
        public long CountryId { get; set; }
        public bool IsValid { get; set; }
    }
}