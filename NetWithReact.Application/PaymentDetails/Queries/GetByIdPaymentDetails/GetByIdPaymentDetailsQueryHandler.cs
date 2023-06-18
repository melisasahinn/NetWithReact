using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Queries.GetByIdPaymentDetails
{
    public class GetByIdPaymentDetailsQueryHandler : IRequestHandler<GetByIdPaymentDetailsQuery, ErrorOr<GetByIdPaymentDetailsQueryResult>>
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public GetByIdPaymentDetailsQueryHandler(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }
        public async Task<ErrorOr<GetByIdPaymentDetailsQueryResult>> Handle(GetByIdPaymentDetailsQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var paymentDetails = _paymentDetailsRepository.GetById(request.Id);

            if (paymentDetails == null || paymentDetails.Id < 1)
            {
                return Errors.NotFound;
            }

            return new GetByIdPaymentDetailsQueryResult(request.Id, paymentDetails.OrderId, paymentDetails.Amount, paymentDetails.Status, paymentDetails.IsActive, paymentDetails.IsDeleted, paymentDetails.CreatedDateTime);
        }
    }
}
