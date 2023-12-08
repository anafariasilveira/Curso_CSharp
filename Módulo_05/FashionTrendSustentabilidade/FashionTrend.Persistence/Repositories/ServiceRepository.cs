using Microsoft.EntityFrameworkCore;

public class ServiceRepository : BaseRepository<Service>, IServiceRepository
{
    public ServiceRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<List<Service>> GetByDescription(string description, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(x => x.Description.Equals(description)).ToListAsync(cancellationToken);
    }
    public async Task<List<Service>> GetByMachine(string machine, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(x => x.SewingMachines.Equals (machine)).ToListAsync(cancellationToken);
    }
    public async Task<List<Service>> GetByMaterial(string material, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(x => x.Materials.Equals (material)).ToListAsync(cancellationToken);
    }
    public async Task<List<Service>> GetByType(string type, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(x => x.RequestType.Equals(type)).ToListAsync(cancellationToken);
    }
}