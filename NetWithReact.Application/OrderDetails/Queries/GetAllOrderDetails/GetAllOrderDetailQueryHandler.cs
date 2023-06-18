using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Queries.GetAllOrderDetails
{
    public class GetAllOrderDetailQueryHandler : IRequestHandler<GetAllOrderDetailQuery, ErrorOr<GetAllOrderDetailQueryResult>>
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        public GetAllOrderDetailQueryHandler(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task<ErrorOr<GetAllOrderDetailQueryResult>> Handle(GetAllOrderDetailQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            if (_orderDetailsRepository.Get(request.Page, request.Size) is not { } orderDetailList)
            {
                return Errors.NotFound;
            }
            int totalRowCount = _orderDetailsRepository.Count();
            int totalPageCount = (int)Math.Ceiling(totalRowCount / (float)request.Size);

            return new GetAllOrderDetailQueryResult(
                request.Page,
                request.Size,
                totalPageCount,
                totalRowCount,
                orderDetailList);
        }
    }
}
