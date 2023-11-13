public interface ISupplierRepository : IBaseRepository<Supplier>
{
    public Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
    public Task<List<Supplier>> GetByMaterials(string material, CancellationToken cancellationToken);
    public Task<List<Supplier>> GetByMachine(string sewingmachine, CancellationToken cancellationToken);
}