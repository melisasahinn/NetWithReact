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

namespace NetWithReact.Application.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ErrorOr<Product>>
    {
        private readonly IProductRepository _repository;
        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ErrorOr<Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var product = new Product
            {
                Name = request.Name,
                ProductCategoryId = request.ProductCategoryId,
                ProductInventoryId = request.ProductInventoryId,
                DiscountId = request.DiscountId,
                Price = request.Price,
                CreatedDateTime = DateTime.Now
            };

            var persistenceResult = _repository.Add(product);

            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.NotFound;
            }
            return persistenceResult;
        }
    }
}
