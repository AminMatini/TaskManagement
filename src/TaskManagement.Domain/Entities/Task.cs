namespace TaskManagement.Domain.Entities;

public class Task : BaseEntity<long>
{
    public int CreatorId { get; set; }
    public long? ParentId { get; set; }

    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsDone { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime DoneDate { get; set; }

    public virtual User Creator { get; set; } = null!;
    public virtual Task? Parent { get; set; }
    public virtual ICollection<Task>? SubTasks { get; set; }
    public virtual ICollection<TaskItem>? Items { get; set; }
}
