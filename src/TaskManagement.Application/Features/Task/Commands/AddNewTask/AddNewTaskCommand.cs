namespace TaskManagement.Application.Features.Task.Commands.AddNewTask;

/// <summary>
/// Command Request Model 
/// </summary>
public record AddNewTaskCommand : IRequest
{
    internal bool IsDone { get; set; }
    internal long? ParentId { get; set; }

    public int CreatorId { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime Deadline { get; set; }

    public AddNewTaskCommand()
    {
        IsDone = false;
        ParentId = null;   
    }
}
