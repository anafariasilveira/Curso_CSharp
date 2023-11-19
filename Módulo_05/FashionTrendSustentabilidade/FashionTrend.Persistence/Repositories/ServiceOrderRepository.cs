using Microsoft.EntityFrameworkCore;

public class ServiceOrderRepository : BaseRepository<ServiceOrder>, IServiceOrderRepository
{
    public ServiceOrderRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<ServiceOrder> GetByServiceId(Guid idService, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.FirstOrDefaultAsync(
            x => x.ServiceId.Equals(idService), cancellationToken);
    }

    public async Task<ServiceOrder> GetByType(ERequestType type, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.FirstOrDefaultAsync(
            x => x.Type.Equals(type), cancellationToken);
    }

    public async Task<ServiceOrder> GetBySupplierId(Guid idSupplier, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.FirstOrDefaultAsync(
            x => x.SupplierId.Equals(idSupplier), cancellationToken);
    }

}