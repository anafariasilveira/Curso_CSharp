public interface IUnitOfWork
{
    public Task Commit(CancellationToken cancellationToken);
}