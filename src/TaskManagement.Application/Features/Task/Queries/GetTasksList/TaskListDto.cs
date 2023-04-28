namespace TaskManagement.Application.Features.Task.Queries.GetTasksList;

public class TaskListDto
{
    public long Id { get; set; }
    public int CreatorId { get; set; }
    public long? ParentId { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsDone { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime DoneDate { get; set; }
}