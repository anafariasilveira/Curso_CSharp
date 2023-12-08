public interface IServiceRepository : IBaseRepository<Service>
{
    public Task<List<Service>> GetByType(string type, CancellationToken cancellationToken);
    public Task<List<Service>> GetByMachine(string machine, CancellationToken cancellationToken);
    public Task<List<Service>> GetByMaterial(string material, CancellationToken cancellationToken);
    public Task<List<Service>> GetByDescription(string description, CancellationToken cancellationToken);
}