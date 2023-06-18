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

namespace NetWithReact.Application.OrderDetails.Command.DeleteOrderDetail
{
    public class DeleteOrderDetailCommandHandler : IRequestHandler<DeleteOrderDetailCommand, ErrorOr<NetWithReact.Domain.Entities.OrderDetails>>
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        public DeleteOrderDetailCommandHandler(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task<ErrorOr<Domain.Entities.OrderDetails>> Handle(DeleteOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var orderDetail = _orderDetailsRepository.GetById(request.Id);
            if (orderDetail == null || orderDetail.Id < 1)
            {
                return Errors.NotFound;
            }

            var deleteResult = _orderDetailsRepository.Delete(orderDetail);
            if (deleteResult != null)
            {
                return Errors.NotFound;
            }

            return deleteResult;
        }
    }
}
