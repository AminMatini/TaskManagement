namespace TaskManagement.Application.Features.Task.Queries.GetTasksList;

public record GetTasksListQuery : IRequest<List<TaskListDto>>
{
    public int UserId { get; set; }
    public GetTasksListQuery(int userId)
    {
        UserId = userId;
    }
}