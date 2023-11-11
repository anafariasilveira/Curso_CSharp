namespace FashionTrend.Domain.Interfaces
{
    public interface IUnitOfWork
    {
       public Task Commit(CancellationToken cancellationToken);
    }
}
