namespace TaskManagement.Application.Features.SubTask.Commands.AddNewSubTask;

/// <summary>
/// Command Request Model 
/// </summary>
public record AddNewSubTaskCommand : IRequest
{
    public int CreatorId { get; set; }
    public long ParentId { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime Deadline { get; set; }

    internal bool IsDone { get; set; }

    public AddNewSubTaskCommand()
    {
        IsDone = false;
    }
}