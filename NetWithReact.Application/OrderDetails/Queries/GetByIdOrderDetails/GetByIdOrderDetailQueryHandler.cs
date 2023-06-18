using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Queries.GetByIdOrderDetails
{
    public record GetByIdOrderDetailQueryHandler : IRequestHandler<GetByIdOrderDetailQuery, ErrorOr<GetByIdOrderDetailQueryResult>>
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        public GetByIdOrderDetailQueryHandler(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }
        public async Task<ErrorOr<GetByIdOrderDetailQueryResult>> Handle(GetByIdOrderDetailQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var orderDetail = _orderDetailsRepository.GetById(request.Id);
            if (orderDetail == null || orderDetail.Id < 1)
            {
                return Errors.NotFound;
            }

            return new GetByIdOrderDetailQueryResult(request.Id, orderDetail.UserId, orderDetail.Total, orderDetail.PaymentDetailsId, orderDetail.IsActive, orderDetail.IsDeleted, orderDetail.CreatedDateTime);
        }
    }
}
