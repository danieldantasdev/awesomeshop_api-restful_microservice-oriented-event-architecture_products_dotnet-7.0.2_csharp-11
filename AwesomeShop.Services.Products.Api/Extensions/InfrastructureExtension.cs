using AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;
using AwesomeShop.Services.Products.Infrastructure.Persistence.Repositories.Implementations;

namespace AwesomeShop.Services.Products.Api.Extensions;

public static class InfrastructureExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        return serviceCollection;
    }
}