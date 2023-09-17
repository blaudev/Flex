namespace Flex.Domain;

public class Entity : IEntity
{
    public int Id { get; private set; }

    protected Entity() { }
}
