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

namespace NetWithReact.Application.Discounts.Command.CreateDiscount
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, ErrorOr<Discount>>
    {
        private readonly IDiscountRepository _discountRepository;
        public CreateDiscountCommandHandler(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<ErrorOr<Discount>> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var discount = new Discount
            {
                Name = request.Name,
                DiscountPercent = request.DiscountPercent,
                CreatedDateTime = DateTime.Now
            };

            var persistenceResult = _discountRepository.Add(discount);
            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.DbPersistence;
            }
            return persistenceResult;
        }
    }
}
