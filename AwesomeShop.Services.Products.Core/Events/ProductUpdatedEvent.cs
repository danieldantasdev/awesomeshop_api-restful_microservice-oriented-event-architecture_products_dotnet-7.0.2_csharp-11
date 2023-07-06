using AwesomeShop.Services.Products.Core.Events.Interfaces;

namespace AwesomeShop.Services.Products.Core.Events;

public class ProductUpdatedEvent : IDomainEvent
{
    public ProductUpdatedEvent(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; private set; }
}