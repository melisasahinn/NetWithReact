using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetByIdCartItems
{
    public record CartItemGetByIdQueryResult(long Id, long ShoppingSessionId, long ProductId, long Quantity, bool IsActive, bool IsDeleted, DateTime CreatedDateTime);
}
