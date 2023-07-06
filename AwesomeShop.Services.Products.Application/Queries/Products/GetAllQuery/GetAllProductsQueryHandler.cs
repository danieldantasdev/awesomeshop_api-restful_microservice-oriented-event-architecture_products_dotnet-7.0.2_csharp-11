using AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Queries.Products.GetAllQuery;

public class
    GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryInputModel, List<GetAllProductsQueryViewModel>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<GetAllProductsQueryViewModel>> Handle(GetAllProductsQueryInputModel request,
        CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync();

        return products
            .Select(p => new GetAllProductsQueryViewModel(p.Id, p.Title))
            .ToList();
    }
}