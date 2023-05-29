using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Queries.GetByIdDiscounts
{
    public class GetByIdDiscountQueryHandler : IRequestHandler<GetByIdDiscountQuery, ErrorOr<GetByIdDiscountQueryResult>>
    {
        private readonly IDiscountRepository _discountRepository;
        public GetByIdDiscountQueryHandler(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<ErrorOr<GetByIdDiscountQueryResult>> Handle(GetByIdDiscountQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var discount = _discountRepository.GetById(request.Id);

            if (discount == null || discount.Id < 1)
            {
                return Errors.NotFound;
            }

            return new GetByIdDiscountQueryResult(request.Id, discount.Name, discount.DiscountPercent);
        }
    }
}
