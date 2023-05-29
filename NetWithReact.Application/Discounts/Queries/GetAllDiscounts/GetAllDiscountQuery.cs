using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Queries.GetAllDiscounts
{
    public record GetAllDiscountQuery : BaseQuery, IRequest<ErrorOr<GetAllDiscountQueryResult>>


}
