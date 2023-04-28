namespace TaskManagement.Domain.Entities;

public class User : BaseEntity<int>
{
    public string Title { get; set; } = null!;

    public virtual ICollection<Task>? Tasks { get; set; }
}
