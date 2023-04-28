namespace TaskManagement.Application.Features.SubTask.Commands.AddNewSubTask;

public class AddNewSubTaskCommandHandler : IRequestHandler<AddNewSubTaskCommand>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    public AddNewSubTaskCommandHandler(ITaskRepository taskRepository,
        IUnitOfWorkAsync unitOfWorkAsync)
    {
        _taskRepository = taskRepository;
        _unitOfWorkAsync = unitOfWorkAsync;
    }
    public System.Threading.Tasks.Task Handle(AddNewSubTaskCommand request, CancellationToken cancellationToken)
    {
        // TODO : Implement Logic
        throw new NotImplementedException();
    }
}
