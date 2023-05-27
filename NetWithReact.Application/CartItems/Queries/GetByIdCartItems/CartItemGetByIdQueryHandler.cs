using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetByIdCartItems
{
    public class CartItemGetByIdQueryHandler : IRequestHandler<CartItemGetByIdQuery, ErrorOr<CartItemGetByIdQueryResult>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public CartItemGetByIdQueryHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<ErrorOr<CartItemGetByIdQueryResult>> Handle(CartItemGetByIdQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var cartItem = _cartItemRepository.GetById(request.Id);

            if (cartItem == null || cartItem.Id < 1)
            {
                return Errors.NotFound;
            }
            return new CartItemGetByIdQueryResult(request.Id, cartItem.ShoppingSessionId, cartItem.ProductId, cartItem.Quantity, cartItem.IsActive, cartItem.IsDeleted, cartItem.CreatedDateTime);
        }
    }
}
