using AwesomeShop.Services.Products.Application.Commands.Products.AddCommand;

namespace AwesomeShop.Services.Products.Api.Extensions;

public static class MediatorExtension
{
    public static IServiceCollection AddMediatRExtension(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly,
                typeof(AddProductCommandInputModel).Assembly);
        });
        return serviceCollection;
    }
}