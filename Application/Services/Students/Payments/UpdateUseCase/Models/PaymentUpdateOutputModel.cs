using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Payments.UpdateUseCase.Models
{
    public class PaymentUpdateOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public PaymentUpdateOutputModelFields OutputModelFields { get; set; } 
    }
}