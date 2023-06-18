using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Command.UpdatePaymentDetail
{
    public record UpdatePaymentDetailCommand(long Id, long OrderId, int Amount, string Status, bool IsActive, bool IsDeleted, DateTime CreatedDateTime) : IRequest<ErrorOr<NetWithReact.Domain.Entities.PaymentDetails>>;

}
