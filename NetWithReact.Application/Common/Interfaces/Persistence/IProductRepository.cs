﻿using NetWithReact.Application.Common.Interfaces.Persistence.Common;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Common.Interfaces.Persistence
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}
