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

namespace NetWithReact.Application.CartItems.Command.CreateCartItem
{
    public class CreateCartItemCommandHandler : IRequestHandler<CreateCartItemCommand, ErrorOr<CartItem>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public CreateCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public async Task<ErrorOr<CartItem>> Handle(CreateCartItemCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var cartItem = new CartItem
            {
                ShoppingSessionId = request.ShoppingSessionId,
                ProductId = request.ProductId,
                CreatedDateTime= DateTime.Now
            };

            var persistenceResult = _cartItemRepository.Add(cartItem);

            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.DbPersistence;
            }
            return persistenceResult;
        }
    }
}
