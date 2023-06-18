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

namespace NetWithReact.Application.PaymentDetails.Command.UpdatePaymentDetail
{
    public class UpdatePaymentDetailCommandHandler : IRequestHandler<UpdatePaymentDetailCommand, ErrorOr<NetWithReact.Domain.Entities.PaymentDetails>>
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public UpdatePaymentDetailCommandHandler(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }
        public async Task<ErrorOr<Domain.Entities.PaymentDetails>> Handle(UpdatePaymentDetailCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var paymentDetail = _paymentDetailsRepository.GetById(request.Id);
            if (paymentDetail == null || paymentDetail.Id < 1)
            {
                return Errors.NotFound;
            }

            paymentDetail.OrderId = request.OrderId;
            paymentDetail.Amount = request.Amount;
            paymentDetail.Status = request.Status;

            var updateResult = _paymentDetailsRepository.Update(paymentDetail);
            if (updateResult == null)
            {
                return Errors.NotFound;
            }
            return updateResult;

        }


    }
}
