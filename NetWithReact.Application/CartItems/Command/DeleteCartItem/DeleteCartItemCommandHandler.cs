using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Command.DeleteCartItem
{
    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, ErrorOr<CartItem>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public DeleteCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<ErrorOr<CartItem>> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var cartItem = _cartItemRepository.GetById(request.Id);

            if (cartItem == null || cartItem.Id < 1)
            {
                return Error.NotFound();
            }

            var deleteResult = _cartItemRepository.Delete(cartItem);
            if (deleteResult == null)
            {
                return Error.NotFound();
            }
            return deleteResult;
        }

    }
}
