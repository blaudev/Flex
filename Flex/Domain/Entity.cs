using MediatR;

namespace Flex.Domain;

public abstract class Entity<T> : IEntity<T> where T : notnull
{
    public T Id { get; init; } = default!;

    private readonly List<INotification> _events = new();
    public IReadOnlyCollection<INotification> Events => _events.AsReadOnly();

    public void AddEvent(INotification @event)
    {
        _events.Add(@event);
    }

    public void clearEvents()
    {
        _events.Clear();
    }
}
