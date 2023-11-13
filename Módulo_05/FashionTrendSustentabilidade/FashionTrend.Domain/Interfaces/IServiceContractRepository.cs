public interface IServiceContractRepository : IBaseRepository<ServiceContract>
{
    public Task<ServiceContract> GetOrderId(Guid orderId, CancellationToken cancellationToken);
    public Task<ServiceContract> GetSupplierId(Guid supplierId, CancellationToken cancellationToken);
    //public Task<EContractStatus> Status(EContractStatus status, CancellationToken cancellationToken);
}