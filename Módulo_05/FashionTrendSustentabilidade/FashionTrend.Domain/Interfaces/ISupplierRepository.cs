public interface ISupplierRepository : IBaseRepository<Supplier>
{
    public Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
    public Task<Supplier> GetByMachines(List<ESewingMachine> machines, CancellationToken cancellationToken);
}