using AwesomeShop.Services.Products.Application.Dtos.Categories;
using AwesomeShop.Services.Products.Core.Entities;
using AwesomeShop.Services.Products.Core.ValueObjects.Categories;
using MediatR;

namespace AwesomeShop.Services.Products.Application.Commands.Products.AddCommand;

public class AddProductCommandInputModel : IRequest<AddProductCommandViewModel>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public CategoryDto Category { get; set; }

    public Product ToEntity()
    {
        return new Product(Title, Description, Price, Quantity,
            new CategoryValueObject(Category.Description, Category.Subcategory));
    }
}