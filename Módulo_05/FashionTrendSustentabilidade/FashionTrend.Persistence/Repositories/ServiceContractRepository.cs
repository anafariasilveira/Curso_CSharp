using Microsoft.EntityFrameworkCore;

public class ServiceContractRepository : BaseRepository<ServiceContract>, IServiceContractRepository
{
    public ServiceContractRepository(AppDbContext context) : base(context)
    {

    }
    public async Task<ServiceContract> GetOrderId(Guid orderId, CancellationToken cancellationToken)
    {
        return await Context.ServiceContract.FirstOrDefaultAsync(
            x => x.OrderId.Equals(orderId), cancellationToken);
    }

    public async Task<ServiceContract> GetSupplierId(Guid supplierId, CancellationToken cancellationToken)
    {
        return await Context.ServiceContract.FirstOrDefaultAsync(
            x => x.SupplierId.Equals(supplierId), cancellationToken);
    }
    //public async Task<EContractStatus> Status(EContractStatus status, CancellationToken cancellationToken)
    //{
    //    return await Context.ServiceContract.Where(
    //        x => x.Status.Equals(status), cancellationToken);
    //}
}