namespace TaskManagement.Domain.Entities;

public class TaskItem : BaseEntity<long>
{
    public long TaskId { get; set; }

    public string Title { get; set; } = null!;
    public bool IsDone { get; set; }

    public virtual Task Task { get; set; } = null!;
}
