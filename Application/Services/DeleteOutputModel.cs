using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services
{
    public class DeleteOutputModel
    {
        public bool HasError { get; set; } = false;
        public string Message { get; set; }
    }
}
