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

namespace NetWithReact.Application.OrderDetails.Command.UpdateOrderDetail
{
    public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommand, ErrorOr<NetWithReact.Domain.Entities.OrderDetails>>
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        public UpdateOrderDetailCommandHandler(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task<ErrorOr<Domain.Entities.OrderDetails>> Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var orderDetail = _orderDetailsRepository.GetById(request.Id);
            if (orderDetail == null || orderDetail.Id < 1)
            {
                return Errors.NotFound;
            }

            orderDetail.Total = request.Total;
            orderDetail.PaymentDetailsId = request.PaymentDetailsId;
            orderDetail.UserId = request.UserId;

            var updateResult = _orderDetailsRepository.Update(orderDetail);
            if (updateResult == null)
            {
                return Errors.NotFound;
            }

            return updateResult;


        }
    }
}
