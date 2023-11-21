using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories.Students
{
    internal class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        private readonly DataBaseContext context;
        public PaymentRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }


    }
}
