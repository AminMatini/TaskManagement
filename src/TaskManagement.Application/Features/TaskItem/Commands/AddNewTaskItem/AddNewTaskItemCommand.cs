namespace TaskManagement.Application.Features.TaskItem.Commands.AddNewTaskItem;

public class AddNewTaskItemCommand : IRequest
{
    public long TaskId { get; set; }
    public string Title { get; set; } = null!;

    internal bool IsDone { get; set; }

    public AddNewTaskItemCommand()
    {
        IsDone = false;
    }
}
