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

namespace NetWithReact.Application.CartItems.Command.UpdateCartItem
{
    public class UpdateCartItemCommandHandler : IRequestHandler<UpdateCartItemCommand, ErrorOr<CartItem>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public UpdateCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<ErrorOr<CartItem>> Handle(UpdateCartItemCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var cartItem = _cartItemRepository.GetById(request.Id);

            if (cartItem == null || cartItem.Id < 1)
            {
                return Errors.NotFound;
            }

            cartItem.ShoppingSessionId = request.ShoppingSessionId;
            cartItem.ProductId = request.ProductId;

            var updateResult = _cartItemRepository.Update(cartItem);

            if (updateResult == null)
            {
                return Errors.NotFound;
            }

            return updateResult;
        }
    }
}
