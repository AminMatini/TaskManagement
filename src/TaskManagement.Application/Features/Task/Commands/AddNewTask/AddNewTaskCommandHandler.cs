namespace TaskManagement.Application.Features.Task.Commands.AddNewTask;

public class AddNewTaskCommandHandler : IRequestHandler<AddNewTaskCommand>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    public AddNewTaskCommandHandler(ITaskRepository taskRepository,
        IUnitOfWorkAsync unitOfWorkAsync)
    {
        _taskRepository = taskRepository;
        _unitOfWorkAsync = unitOfWorkAsync;
    }
    public System.Threading.Tasks.Task Handle(AddNewTaskCommand request, CancellationToken cancellationToken)
    {
        // TODO : Implement Logic
        throw new NotImplementedException();
    }
}