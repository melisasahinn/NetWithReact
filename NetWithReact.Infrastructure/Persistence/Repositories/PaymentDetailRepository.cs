﻿using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Entities;
using NetWithReact.Infrastructure.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Infrastructure.Persistence.Repositories
{
    public class PaymentDetailRepository : EFRepositoryBase<PaymentDetails>, IPaymentDetailsRepository
    {
        public PaymentDetailRepository(NetWithReactDbContext dbContext) : base(dbContext)
        {
        }
    }
}
