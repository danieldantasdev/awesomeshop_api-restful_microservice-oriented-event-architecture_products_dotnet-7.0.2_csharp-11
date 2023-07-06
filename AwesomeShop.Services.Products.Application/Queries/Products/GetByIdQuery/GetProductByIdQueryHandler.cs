using AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Queries.Products.GetByIdQuery;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryInputModel, GetProductByIdQueryViewModel>
{
    private readonly IProductRepository _productRepository;

    public GetProductByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetProductByIdQueryViewModel> Handle(GetProductByIdQueryInputModel request,
        CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.Id);

        var productDetails = GetProductByIdQueryViewModel.FromEntity(product);

        return productDetails;
    }
}