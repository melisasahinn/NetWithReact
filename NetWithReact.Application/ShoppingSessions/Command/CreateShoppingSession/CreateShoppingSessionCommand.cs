using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.ShoppingSessions.Command.CreateShoppingSession
{
    public record CreateShoppingSessionCommand(long UserId) : IRequest<ErrorOr<ShoppingSession>>;

}
