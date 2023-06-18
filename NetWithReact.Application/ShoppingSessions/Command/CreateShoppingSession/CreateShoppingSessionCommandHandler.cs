using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Application.Products.Command.CreateProduct;
using NetWithReact.Domain.Entities;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.ShoppingSessions.Command.CreateShoppingSession
{
    public class CreateShoppingSessionCommandHandler : IRequestHandler<CreateShoppingSessionCommand, ErrorOr<ShoppingSession>>
    {
        private readonly IShoppingSessionRepository _repository;
        public CreateShoppingSessionCommandHandler(IShoppingSessionRepository repository)
        {
            _repository = repository;
        }

        public async Task<ErrorOr<ShoppingSession>> Handle(CreateShoppingSessionCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var shoppingSession = new ShoppingSession 
            { 
                CreatedDateTime= DateTime.Now,
                UserId= request.UserId,
            };

            var persistenceResult = _repository.Add(shoppingSession);

            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.NotFound;
            }
            return persistenceResult;

        }
    }
}
