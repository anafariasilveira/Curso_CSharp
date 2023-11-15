using Microsoft.EntityFrameworkCore;

public class ServiceRepository : BaseRepository<Service>, IServiceRepository
{
    public ServiceRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<List<Service>> GetByMachine(string sewingmachine, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(
        x => x.SewingMachines.Any(s => s.Equals(sewingmachine))).ToListAsync(cancellationToken);
    }

    public async Task<List<Service>> GetByMaterial(string material, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(
        x => x.Materials.Any(s => s.Equals(material))).ToListAsync(cancellationToken);
    }
    public async Task<List<Service>> GetByType(string type, CancellationToken cancellationToken)
    {
        return await Context.Services.Where(
        x => x.RequestsType.Any(s => s.Equals(type))).ToListAsync(cancellationToken);
    }


}