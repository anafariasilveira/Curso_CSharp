public interface ISupplierRepository : IBaseRepository<Supplier>
{
    public Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
}