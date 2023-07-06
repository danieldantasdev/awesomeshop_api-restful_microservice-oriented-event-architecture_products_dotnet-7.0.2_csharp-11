using AwesomeShop.Services.Products.Application.Dtos.Categories;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Commands.Products.UpdateCommand;

public class UpdateProductCommandInputModel : IRequest<UpdateProductCommandViewModel>
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public CategoryDto Category { get; set; }
}