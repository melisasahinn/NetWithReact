using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Queries.GetByIdPaymentDetails
{
    public record GetByIdPaymentDetailsQueryResult
    (long Id, long OrderId, int Amount, string Status, bool IsActive, bool IsDeleted, DateTime CreatedDateTime);
}
