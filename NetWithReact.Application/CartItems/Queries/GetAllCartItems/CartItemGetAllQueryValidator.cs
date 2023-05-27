using FluentValidation;
using NetWithReact.Application.Common.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetAllCartItems
{
    public class CartItemGetAllQueryValidator : AbstractValidator<CartItemGetAllQuery>
    {
        public CartItemGetAllQueryValidator()
        {
            RuleFor(x => x.Page)
           .NotEmpty()
           .GreaterThanOrEqualTo(QueryConstants.MinPage);
            RuleFor(x => x.Size)
                .NotEmpty()
                .GreaterThanOrEqualTo(QueryConstants.MinSize)
                .LessThanOrEqualTo(QueryConstants.MaxSize);
        }
    }
}
