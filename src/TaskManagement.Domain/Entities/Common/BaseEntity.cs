namespace TaskManagement.Domain.Entities.Common;

public abstract class BaseEntity<TKey> where TKey : IComparable
{
    public TKey Id { get; set; } = default!;
    public DateTime CreateAt { get; set; }
}

public abstract class BaseEntity : BaseEntity<Guid>
{

}
