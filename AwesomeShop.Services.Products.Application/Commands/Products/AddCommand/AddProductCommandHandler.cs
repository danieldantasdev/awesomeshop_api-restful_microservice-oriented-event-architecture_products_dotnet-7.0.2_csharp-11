using AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Commands.Products.AddCommand;

public class AddProductCommandHandler : IRequestHandler<AddProductCommandInputModel, AddProductCommandViewModel>
{
    private readonly IProductRepository _productRepository;

    public AddProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<AddProductCommandViewModel> Handle(AddProductCommandInputModel request,
        CancellationToken cancellationToken)
    {
        var product = request.ToEntity();

        await _productRepository.AddAsync(product);

        return new AddProductCommandViewModel(product.Id);
    }
}