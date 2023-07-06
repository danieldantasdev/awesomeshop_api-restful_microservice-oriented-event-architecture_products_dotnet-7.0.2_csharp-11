using AwesomeShop.Services.Products.Core.Events;
using AwesomeShop.Services.Products.Core.ValueObjects;
using AwesomeShop.Services.Products.Core.ValueObjects.Categories;

namespace AwesomeShop.Services.Products.Core.Entities;

public class Product : AggregateRoot
{
    public Product(string title, string description, decimal price, int quantity,
        CategoryValueObject categoryValueObject)
    {
        Title = title;
        Description = description;
        Price = price;
        Quantity = quantity;
        Category = categoryValueObject;
        CreatedAt = DateTime.Now;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public int Quantity { get; private set; }
    public CategoryValueObject Category { get; private set; }

    public void Update(string description, decimal price, CategoryValueObject categoryValueObject)
    {
        if (categoryValueObject != null) Category = categoryValueObject;

        Description = description;
        Price = price;

        AddEvent(new ProductUpdatedEvent(Id));
    }

    public static Product Create(string title, string description, decimal price, int quantity,
        CategoryValueObject categoryValueObject)
    {
        var product = new Product(title, description, price, quantity, categoryValueObject);

        return product;
    }
}