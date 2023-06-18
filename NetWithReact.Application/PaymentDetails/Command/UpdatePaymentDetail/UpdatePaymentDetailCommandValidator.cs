using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.PaymentDetails.Command.UpdatePaymentDetail
{
    public class UpdatePaymentDetailCommandValidator : AbstractValidator<UpdatePaymentDetailCommand>
    {
        public UpdatePaymentDetailCommandValidator()
        {

        }
    }
}
