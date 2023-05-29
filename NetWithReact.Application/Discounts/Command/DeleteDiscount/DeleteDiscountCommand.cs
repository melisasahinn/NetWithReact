using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Command.DeleteDiscount
{
    public record DeleteDiscountCommand(long Id) : IRequest<ErrorOr<Discount>>;

}
