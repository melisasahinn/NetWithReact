using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Queries.GetAllDiscounts
{
    public record GetAllDiscountQueryResult
       (int CurrentPage,
         int PageSize,
        int TotalPageCount,
        int TotalRowCount,
        List<Discount> Data);
}
