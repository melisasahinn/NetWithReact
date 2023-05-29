using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Queries.GetAllDiscounts
{
    public class GetAllDiscountQueryHandler : IRequestHandler<GetAllDiscountQuery, ErrorOr<GetAllDiscountQueryResult>>
    {
        private readonly IDiscountRepository _discountRepository;
        public GetAllDiscountQueryHandler(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<ErrorOr<GetAllDiscountQueryResult>> Handle(GetAllDiscountQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            if (_discountRepository.Get(request.Page, request.Size) is not { } discountList)
            {
                return Errors.NotFound;
            }

            int totalRowCount = _discountRepository.Count();
            int totalPageCount = (int)Math.Ceiling(totalRowCount / (float)request.Size);

            return new GetAllDiscountQueryResult
                (request.Page,
                request.Size,
                totalPageCount,
                totalRowCount,
                discountList);
        }
    }
}
