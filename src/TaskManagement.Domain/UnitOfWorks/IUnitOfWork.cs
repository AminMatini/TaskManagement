namespace TaskManagement.Domain.UnitOfWorks;

public interface IUnitOfWork : ITransient, IDisposable
{
    void SaveChanges();
    void BeginTransaction();
    void CommitTransaction();
    void RollbackTransaction();
}