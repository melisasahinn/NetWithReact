using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Discounts.Command.DeleteDiscount
{
    public class DeleteDiscountCommandValidator : AbstractValidator<DeleteDiscountCommand>
    {
        public DeleteDiscountCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
