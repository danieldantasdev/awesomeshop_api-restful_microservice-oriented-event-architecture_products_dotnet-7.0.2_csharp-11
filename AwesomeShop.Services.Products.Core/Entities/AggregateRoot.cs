using AwesomeShop.Services.Products.Core.Entities.Interfaces;
using AwesomeShop.Services.Products.Core.Events.Interfaces;

namespace AwesomeShop.Services.Products.Core.Entities;

public abstract class AggregateRoot : IEntityBase
{
    private readonly List<IDomainEvent> _events = new();
    public Guid Id { get; protected set; }
    public IEnumerable<IDomainEvent> Events => _events;

    protected void AddEvent(IDomainEvent @event)
    {
        _events.Add(@event);
    }
}