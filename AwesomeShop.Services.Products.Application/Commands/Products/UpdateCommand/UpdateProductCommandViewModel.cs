using AwesomeShop.Services.Products.Core.Entities;

namespace AwesomeShop.Services.Products.Application.Commands.Products.UpdateCommand;

public class UpdateProductCommandViewModel
{
    public UpdateProductCommandViewModel(Guid id, string title, string description, decimal price, int quantity)
    {
        Id = id;
        Title = title;
        Description = description;
        Price = price;
        Quantity = quantity;
    }

    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }
    
    public static UpdateProductCommandViewModel FromEntity(Product product)
    {
        return new UpdateProductCommandViewModel(
            product.Id,
            product.Title,
            product.Description,
            product.Price,
            product.Quantity
        );
    }
}