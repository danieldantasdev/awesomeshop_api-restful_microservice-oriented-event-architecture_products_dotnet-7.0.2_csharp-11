using AwesomeShop.Services.Products.Core.Events.Interfaces;

namespace AwesomeShop.Services.Products.Core.Events;

public class ProductCreatedEvent : IDomainEvent
{
    public ProductCreatedEvent(Guid id, string description)
    {
        Id = id;
        Description = description;
    }

    public Guid Id { get; private set; }
    public string Description { get; private set; }
}