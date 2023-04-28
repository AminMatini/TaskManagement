namespace TaskManagement.Domain.Entities.Common;

public abstract class BaseEntity<TKey> where TKey : IComparable
{
    public TKey Id { get; set; } = default!;
}

public abstract class BaseEntity : BaseEntity<Guid>
{

}
