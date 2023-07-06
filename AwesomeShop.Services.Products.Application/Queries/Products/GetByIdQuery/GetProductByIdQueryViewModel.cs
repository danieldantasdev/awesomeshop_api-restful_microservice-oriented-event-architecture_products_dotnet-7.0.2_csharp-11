using AwesomeShop.Services.Products.Core.Entities;

namespace AwesomeShop.Services.Products.Application.Queries.Products.GetByIdQuery;

public class GetProductByIdQueryViewModel
{
    public GetProductByIdQueryViewModel(Guid id, string title, string description, decimal price, int quantity)
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

    public static GetProductByIdQueryViewModel FromEntity(Product product)
    {
        return new GetProductByIdQueryViewModel(
            product.Id,
            product.Title,
            product.Description,
            product.Price,
            product.Quantity
        );
    }
}