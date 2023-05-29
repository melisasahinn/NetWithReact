using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Command.CreateDiscount
{
    public record CreateDiscountCommand(string Name, decimal DiscountPercent):IRequest<ErrorOr<Discount>>;

}
