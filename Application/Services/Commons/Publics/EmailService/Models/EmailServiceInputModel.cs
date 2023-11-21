using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Publics.EmailService.Models
{
    public class EmailServiceInputModel
    {
        public string Email { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }
}
