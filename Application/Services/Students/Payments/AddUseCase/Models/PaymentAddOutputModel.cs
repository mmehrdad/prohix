using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Payments.AddUseCase.Models
{
    public class PaymentAddOutputModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public PaymentAddOutputModelFields OutputModelFields { get; set; } 
    }
}