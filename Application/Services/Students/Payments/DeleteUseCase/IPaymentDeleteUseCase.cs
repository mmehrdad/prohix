using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Students.Payments.DeleteUseCase
{
    public interface IPaymentDeleteUseCase: IScopedDependency
    {
      Task<DeleteOutputModel> DeletePayment(int Id); 
    }
}