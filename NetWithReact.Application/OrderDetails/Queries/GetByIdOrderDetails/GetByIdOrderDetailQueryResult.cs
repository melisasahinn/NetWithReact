using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Queries.GetByIdOrderDetails
{
    public record GetByIdOrderDetailQueryResult
     (long Id, long UserId, decimal Total, long PaymentDetailsId, bool IsActive, bool IsDeleted, DateTime CreatedDateTime);
}
