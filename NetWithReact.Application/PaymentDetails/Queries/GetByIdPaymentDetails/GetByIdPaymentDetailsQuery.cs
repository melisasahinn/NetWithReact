using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Queries.GetByIdPaymentDetails
{
    public record GetByIdPaymentDetailsQuery : BaseQuery, IRequest<ErrorOr<GetByIdPaymentDetailsQueryResult>>;

}
