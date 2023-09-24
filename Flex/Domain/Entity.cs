namespace Flex.Domain;

public abstract class Entity<T> : IEntity<T> where T : notnull
{
    public T Id { get; init; } = default!;
}
