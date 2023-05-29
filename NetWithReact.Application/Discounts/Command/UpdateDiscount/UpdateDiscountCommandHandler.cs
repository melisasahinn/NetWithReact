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

namespace NetWithReact.Application.Discounts.Command.UpdateDiscount
{
    public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, ErrorOr<Discount>>
    {
        private readonly IDiscountRepository _discountRepository;
        public UpdateDiscountCommandHandler(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<ErrorOr<Discount>> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var discount = _discountRepository.GetById(request.Id);
            if (discount == null || discount.Id < 1)
            {
                return Errors.NotFound;
            }
            discount.Name = request.Name;
            discount.DiscountPercent = request.DiscountPercent;

            var updateResult = _discountRepository.Update(discount);
            if (updateResult == null)
            {
                return Errors.NotFound;
            }
            return updateResult;
        }
    }
}
