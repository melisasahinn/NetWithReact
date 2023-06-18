using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Command.CreateOrderDetail
{
    public record CreateOrderDetailCommand(long UserId, decimal Total, long PaymentDetailsId, bool IsActive, bool IsDeleted, DateTime CreatedDateTime) : IRequest<ErrorOr<NetWithReact.Domain.Entities.OrderDetails>>;

}
