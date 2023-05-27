using ErrorOr;
using MediatR;
using NetWithReact.Application.CartItems.Queries.GetByIdCartItems;
using NetWithReact.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetAllCartItems
{
    public record CartItemGetAllQuery : BaseQuery, IRequest<ErrorOr<CartItemGetAllQueryResult>>;


}
