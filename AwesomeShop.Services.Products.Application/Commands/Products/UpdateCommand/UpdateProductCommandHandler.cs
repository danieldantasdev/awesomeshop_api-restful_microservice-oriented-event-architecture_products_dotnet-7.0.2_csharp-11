using AwesomeShop.Services.Products.Core.Repositories.Interfaces.Products;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Commands.Products.UpdateCommand;

public class
    UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandInputModel, UpdateProductCommandViewModel>
{
    private readonly IProductRepository _productRepository;

    public UpdateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<UpdateProductCommandViewModel> Handle(UpdateProductCommandInputModel request,
        CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.Id);

        product.Update(request.Description, request.Price, request.Category.ToValueObject());

        await _productRepository.UpdateAsync(product);

        return new UpdateProductCommandViewModel();
    }
}