using Prohix.Application.Services.Students.Payments.AddUseCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Payments.AddUseCase
{
    public class PaymentAddUseCase : IPaymentAddUseCase
    {
        public Task<PaymentAddOutputModel> AddPayment(PaymentAddInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}