using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Queries.GetByIdDiscounts
{
    public record GetByIdDiscountQueryResult(long Id, string Name, decimal DiscountPercent);
    {
    }
}
