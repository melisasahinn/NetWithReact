using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Command.DeletePaymentDetail
{
    public class DeletePaymentDetailCommandValidator : AbstractValidator<DeletePaymentDetailCommand>
    {
        public DeletePaymentDetailCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

        }
    }
}
