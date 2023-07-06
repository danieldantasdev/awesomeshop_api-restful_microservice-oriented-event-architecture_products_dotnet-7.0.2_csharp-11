using AwesomeShop.Services.Products.Core.ValueObjects.Categories;

namespace AwesomeShop.Services.Products.Application.Dtos.Categories;

public class CategoryDto
{
    public string Description { get; set; }
    public string Subcategory { get; set; }

    public CategoryValueObject ToValueObject()
    {
        return new CategoryValueObject(Description, Subcategory);
    }
}