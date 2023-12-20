public interface ISupplierRepository : IBaseRepository<Supplier>
{
    public Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
    public Task<List<Supplier>> GetByMachine(ESewingMachine machines, CancellationToken cancellationToken);
    public Task<List<Supplier>> GetByMaterial(EMaterial material, CancellationToken cancellationToken);

}