using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Queries.GetByIdOrderDetails
{
    public record GetByIdOrderDetailQuery : BaseQuery, IRequest<ErrorOr<GetByIdOrderDetailQueryResult>>;

}
