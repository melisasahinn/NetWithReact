using ErrorOr;
using MediatR;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Application.PaymentDetails.Command.CreatePaymentDetail;
using NetWithReact.Domain.Entities;
using NetWithReact.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.ProductInventories.Command.CreateProductInventory
{
    public class CreateProductInventoryCommandHandler : IRequestHandler<CreateProductInventoryCommand, ErrorOr<ProductInventory>>
    {
        private readonly IProductInventoryRepository _repository;
        public CreateProductInventoryCommandHandler(IProductInventoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<ErrorOr<ProductInventory>> Handle(CreateProductInventoryCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var productInventory = new ProductInventory
            {
                CreatedDateTime = DateTime.Now,
                Quantity = request.Quantity,
            };

            var persistenceResult = _repository.Add(productInventory);

            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.NotFound;
            }
            return persistenceResult;
        }
    }
}
