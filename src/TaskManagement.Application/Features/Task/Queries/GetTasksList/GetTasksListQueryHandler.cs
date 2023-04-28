namespace TaskManagement.Application.Features.Task.Queries.GetTasksList;

public class GetTasksListQueryHandler : IRequestHandler<GetTasksListQuery, List<TaskListDto>>
{
    private readonly ITaskRepository _taskRepository;
    public GetTasksListQueryHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }
    public Task<List<TaskListDto>> Handle(GetTasksListQuery request, CancellationToken cancellationToken)
    {
        //TODO : Implementation Query

        throw new NotImplementedException();
    }
}
