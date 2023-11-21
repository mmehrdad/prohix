using Prohix.Application.Services.Students.Payments.UpdateUseCase.Models;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Payments.UpdateUseCase
{
    public interface IPaymentUpdateUseCase: IScopedDependency
    {
        Task<PaymentUpdateOutputModel> UpdatePayment(PaymentUpdateInputModel inputModel);  
    }
}