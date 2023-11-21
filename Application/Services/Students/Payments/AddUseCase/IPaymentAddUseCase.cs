using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prohix.Application.Services.Students.Payments.AddUseCase.Models;
using Prohix.Infrastracture.Utilities;

namespace Prohix.Application.Services.Students.Payments.AddUseCase
{
    public interface IPaymentAddUseCase : IScopedDependency
    {
      Task<PaymentAddOutputModel> AddPayment(PaymentAddInputModel inputModel);  
    }
}