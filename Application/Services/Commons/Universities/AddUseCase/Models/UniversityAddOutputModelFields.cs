using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Universities.AddUseCase.Models
{
    public class UniversityAddOutputModelFields
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; }
        public bool IsValid { get; set; }
    }
}