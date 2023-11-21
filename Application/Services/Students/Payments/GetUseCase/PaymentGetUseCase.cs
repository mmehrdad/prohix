using Prohix.Core.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Payments.GetUseCase
{
    public class PaymentGetUseCase : IPaymentGetUseCase
    {
        public IQueryable<Payment> GetPayment()
        {
            throw new NotImplementedException();
        }
    }
}