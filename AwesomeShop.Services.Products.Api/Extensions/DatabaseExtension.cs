using AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;
using AwesomeShop.Services.Products.Infrastructure.Persistence.Options;
using AwesomeShop.Services.Products.Infrastructure.Persistence.Repositories.Implementations;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AwesomeShop.Services.Products.Api.Extensions;

public static class DatabaseExtension
{
    public static IServiceCollection AddMongoExtension(this IServiceCollection services)
    {
        services.AddSingleton(sp =>
        {
            var configuration = sp.GetService<IConfiguration>();

            var options = new MongoDbOption();
            configuration?.GetSection("MongoDb").Bind(options);

            return options;
        });

        services.AddSingleton(sp =>
        {
            var options = sp.GetService<MongoDbOption>();

            return new MongoClient(options?.ConnectionString);
        });

        services.AddTransient(sp =>
        {
            BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;

            var options = sp.GetService<MongoDbOption>();
            var mongoClient = sp.GetService<MongoClient>();

            return mongoClient?.GetDatabase(options?.Database);
        });

        return services;
    }

    public static IServiceCollection AddRepositoriesExtension(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}