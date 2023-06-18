using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Command.DeleteOrderDetail
{
    public record DeleteOrderDetailCommand(long Id) : IRequest<ErrorOr<NetWithReact.Domain.Entities.OrderDetails>>;

}
