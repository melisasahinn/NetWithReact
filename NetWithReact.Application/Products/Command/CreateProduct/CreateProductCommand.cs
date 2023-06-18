using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Products.Command.CreateProduct
{
    public record CreateProductCommand(string Name, long ProductCategoryId, long ProductInventoryId, long DiscountId, decimal Price, DateTime CreatedDateTime) : IRequest<ErrorOr<Product>>;
   
}
