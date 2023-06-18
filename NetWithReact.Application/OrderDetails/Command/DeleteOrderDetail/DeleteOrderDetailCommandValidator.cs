using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.OrderDetails.Command.DeleteOrderDetail
{
    public class DeleteOrderDetailCommandValidator : AbstractValidator<DeleteOrderDetailCommand>
    {
        public DeleteOrderDetailCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
