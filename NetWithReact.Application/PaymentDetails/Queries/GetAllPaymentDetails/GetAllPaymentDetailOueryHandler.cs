using ErrorOr;
using MediatR;
using NetWithReact.Application.CartItems.Queries.GetAllCartItems;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Queries.GetAllPaymentDetails
{
    public class GetAllPaymentDetailOueryHandler : IRequestHandler<GetAllPaymentDetailOuery, ErrorOr<GetAllPaymentDetailOueryResult>>
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public GetAllPaymentDetailOueryHandler(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }

        public async Task<ErrorOr<GetAllPaymentDetailOueryResult>> Handle(GetAllPaymentDetailOuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            if (_paymentDetailsRepository.Get(request.Page, request.Size) is not { } paymentDetailList)
            {
                return Errors.NotFound;
            }

            int totalRowCount = _paymentDetailsRepository.Count();
            int totalPageCount = (int)Math.Ceiling(totalRowCount / (float)request.Size);

            return new GetAllPaymentDetailOueryResult(request.Page,
            request.Size,
            totalPageCount,
            totalRowCount,
            paymentDetailList);

        }
    }
}
