namespace Flex.Domain;

public interface IEntity<T> where T : notnull
{
    T Id { get; }
}