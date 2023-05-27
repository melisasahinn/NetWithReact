using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetByIdCartItems
{
    public record CartItemGetByIdQuery : BaseQuery, IRequest<ErrorOr<CartItemGetByIdQueryResult>>;

}
