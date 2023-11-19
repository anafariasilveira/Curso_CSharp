public interface IServiceOrderRepository : IBaseRepository<ServiceOrder>
{
    public Task<ServiceOrder> GetBySupplierId(Guid idSupplier, CancellationToken cancellationToken);
    public Task<ServiceOrder> GetByServiceId(Guid idService, CancellationToken cancellationToken);
    public Task<ServiceOrder> GetByType(ERequestType type, CancellationToken cancellationToken);
}