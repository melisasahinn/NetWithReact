using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Command.UpdateCartItem
{
    public record UpdateCartItemCommand(long Id, long ShoppingSessionId, long ProductId, long Quantity) : IRequest<ErrorOr<CartItem>>;
}
