namespace TaskManagement.Application.Features.TaskItem.Commands.AddNewTaskItem;

public class AddNewTaskItemCommandHandler : IRequestHandler<AddNewTaskItemCommand>
{
    private readonly ITaskItemRepository _taskRepository;
    private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    public AddNewTaskItemCommandHandler(ITaskItemRepository taskRepository,
        IUnitOfWorkAsync unitOfWorkAsync)
    {
        _taskRepository = taskRepository;
        _unitOfWorkAsync = unitOfWorkAsync;
    }
    public System.Threading.Tasks.Task Handle(AddNewTaskItemCommand request, CancellationToken cancellationToken)
    {
        // TODO : Implement Logic
        throw new NotImplementedException();
    }
}
