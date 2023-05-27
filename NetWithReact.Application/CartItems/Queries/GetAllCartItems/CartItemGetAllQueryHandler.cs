using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.CartItems.Queries.GetAllCartItems
{
    public class CartItemGetAllQueryHandler : IRequestHandler<CartItemGetAllQuery, ErrorOr<CartItemGetAllQueryResult>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        public CartItemGetAllQueryHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<ErrorOr<CartItemGetAllQueryResult>> Handle(CartItemGetAllQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            if(_cartItemRepository.Get(request.Page, request.Size) is not { } cartItemList)
            {
                return Errors.NotFound;
            }

            int totalRowCount = _cartItemRepository.Count();
            int totalPageCount = (int)Math.Ceiling(totalRowCount / (float)request.Size);

            return new CartItemGetAllQueryResult ( 
                request.Page, 
                request.Page, 
                totalRowCount, 
                totalPageCount, 
                cartItemList );
        }
    }
}
