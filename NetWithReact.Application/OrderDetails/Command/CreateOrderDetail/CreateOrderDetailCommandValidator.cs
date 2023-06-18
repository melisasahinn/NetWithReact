using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Command.CreateOrderDetail
{
    public class CreateOrderDetailCommandValidator : IRequestHandler<CreateOrderDetailCommand, ErrorOr<NetWithReact.Domain.Entities.OrderDetails>>
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        public CreateOrderDetailCommandValidator(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task<ErrorOr<NetWithReact.Domain.Entities.OrderDetails>> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var orderDetails = new NetWithReact.Domain.Entities.OrderDetails
            {
                UserId = request.UserId,
                PaymentDetailsId = request.PaymentDetailsId,
                Total = request.Total,
                IsActive = request.IsActive,
                IsDeleted = request.IsDeleted,
                CreatedDateTime = request.CreatedDateTime
            };

            var persistenceResult = _orderDetailsRepository.Add(orderDetails);
            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.NotFound;
            }
            return persistenceResult;
        }
    }
}
