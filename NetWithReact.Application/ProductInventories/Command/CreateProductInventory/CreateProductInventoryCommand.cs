using ErrorOr;
using MediatR;
using NetWithReact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.ProductInventories.Command.CreateProductInventory
{
    public record CreateProductInventoryCommand(long Quantity, bool IsActive, bool IsDeleted, DateTime CreatedDateTime):IRequest<ErrorOr<ProductInventory>>;
}
