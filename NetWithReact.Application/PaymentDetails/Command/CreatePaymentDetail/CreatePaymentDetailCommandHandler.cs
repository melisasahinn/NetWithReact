using ErrorOr;
using FluentValidation;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Entities;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Command.CreatePaymentDetail
{
    public class CreatePaymentDetailCommandHandler : IRequestHandler<CreatePaymentDetailCommand, ErrorOr<
        NetWithReact.Domain.Entities.PaymentDetails>>
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public CreatePaymentDetailCommandHandler(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }

        public async Task<ErrorOr<Domain.Entities.PaymentDetails>> Handle(CreatePaymentDetailCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var paymentDetail = new NetWithReact.Domain.Entities.PaymentDetails
            {
                OrderId = request.OrderId,
                Amount = request.Amount,
                Status = request.Status,
                CreatedDateTime = DateTime.Now,
            };

            var persistenceResult = _paymentDetailsRepository.Add(paymentDetail);
            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.NotFound;
            }
            return persistenceResult;


        }
    }
}
