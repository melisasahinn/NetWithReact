using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Entities;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Command.DeletePaymentDetail
{
    public class DeletePaymentDetailCommandHandler : IRequestHandler<DeletePaymentDetailCommand, ErrorOr<NetWithReact.Domain.Entities.PaymentDetails>>
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public DeletePaymentDetailCommandHandler(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }

        public async Task<ErrorOr<Domain.Entities.PaymentDetails>> Handle(DeletePaymentDetailCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var paymentDetail = _paymentDetailsRepository.GetById(request.Id);
            if (paymentDetail == null || paymentDetail.Id < 1)
            {
                return Errors.NotFound;
            }

            var deleteResult = _paymentDetailsRepository.Delete(paymentDetail);

            if (deleteResult == null)
            {
                return Errors.NotFound;
            }

            return deleteResult;
        }
    }
}
