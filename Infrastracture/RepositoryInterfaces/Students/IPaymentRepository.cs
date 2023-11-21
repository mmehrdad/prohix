﻿using Prohix.Core.Entities.Proposals;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.RepositoryInterfaces.Students
{
    public interface IPaymentRepository : IBaseRepository<Payment>, IScopedDependency
    {
    }
}
