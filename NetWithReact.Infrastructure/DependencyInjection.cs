using Microsoft.Extensions.DependencyInjection;
using NetWithReact.Application.Common.Interfaces.Persistence;
using NetWithReact.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace NetWithReact.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services
                .AddPersistence(configuration) ;
            return services ;
        }
        private static IServiceCollection AddPersistence(this IServiceCollection services,ConfigurationManager configuration)
        {
            services.AddScoped<ICartItemRepository, CartItemRepository>();
            services.AddScoped<IDiscountRepository,DiscountRepository>();
            services.AddScoped<IOrderDetailsRepository, OrderDetailRepository>();
            services.AddScoped<IPaymentDetailsRepository, PaymentDetailRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductInventoryRepository,ProductInventoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShoppingSessionRepository, ShoppingSessionRepository>();
            services.AddScoped<IUserAddressRepository, UserAddressRepository>();
            services.AddScoped<IUserPaymentRepository, UserPaymentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services ;
        }
    }
}
