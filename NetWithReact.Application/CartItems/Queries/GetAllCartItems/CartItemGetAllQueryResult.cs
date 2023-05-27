using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetAllCartItems
{
    public record CartItemGetAllQueryResult(
        int CurrentPage,
        int PageSize,
        int TotalPageCount,
        int TotalRowCount,
        List<CartItem> Data);
}