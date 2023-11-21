using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Api.Controllers.Commons.Models
{
    public class UniversityUpdateBindingModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; }
        public bool IsValid { get; set; }
    }
}