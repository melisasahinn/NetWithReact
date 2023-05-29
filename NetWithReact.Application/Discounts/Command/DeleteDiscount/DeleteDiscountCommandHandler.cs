
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

namespace NetWithReact.Application.Discounts.Command.DeleteDiscount
{
    public class DeleteDiscountCommandHandler : IRequestHandler<DeleteDiscountCommand, ErrorOr<Discount>>
    {
        private readonly IDiscountRepository _discountRepository;
        public DeleteDiscountCommandHandler(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<ErrorOr<Discount>> Handle(DeleteDiscountCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var discount = _discountRepository.GetById(request.Id);
            if (discount == null || discount.Id < 1)
            {
                return Errors.NotFound;
            }

            var deleteResult = _discountRepository.Delete(discount);

            if (deleteResult != null)
            {
                return Errors.NotFound;
            }

            return deleteResult;

        }
    }
}
