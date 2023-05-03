using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Domain.Entities;
using NetWithReact.Infrastructure.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Infrastructure.Persistence
{
    public class UserAddressRepository : EFRepositoryBase<UserAddress>, IUserAddressRepository
    {
        public UserAddressRepository(NetWithReactDbContext dbContext) : base(dbContext)
        {
        }
    }
}
