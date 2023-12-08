using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

public class ServiceOrderRepository : BaseRepository<ServiceOrder>, IServiceOrderRepository
{
    public ServiceOrderRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<ServiceOrder> GetByServiceId(Guid idService, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.Where(x => x.Service.Equals(idService)).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<ServiceOrder> GetByStatus(EContractStatus status, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.Where(x => x.Status.Equals(status)).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<ServiceOrder> GetBySupplierId(Guid idSupplier, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.Where(x => x.Supplier.Equals(idSupplier)).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<ServiceOrder> GetByType(ERequestType type, CancellationToken cancellationToken)
    {
        return await Context.ServicesOrder.Where(x => x.Type.Equals(type)).FirstOrDefaultAsync(cancellationToken);
    }
}