namespace TaskManagement.Infra.Data.UnitOfWorks;

public class UnitOfWorkAsync : UnitOfWork, IUnitOfWorkAsync
{
    public UnitOfWorkAsync(ApplicationDbContext context) : base(context)
    {
    }

    public ValueTask DisposeAsync() => Context.DisposeAsync();

    public Task SaveChangesAsync(CancellationToken cancellationToken = default) => Context.SaveChangesAsync(cancellationToken);

    public Task BeginTransactionAsync(CancellationToken cancellationToken = default) => Context.Database.BeginTransactionAsync(cancellationToken);

    public Task CommitTransactionAsync(CancellationToken cancellationToken = default) => Context.Database.CommitTransactionAsync(cancellationToken);

    public Task RollbackTransactionAsync(CancellationToken cancellationToken = default) => Context.Database.RollbackTransactionAsync(cancellationToken);
}