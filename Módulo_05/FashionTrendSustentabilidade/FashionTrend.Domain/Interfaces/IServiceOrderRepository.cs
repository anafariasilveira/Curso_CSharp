using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Enums;

namespace FashionTrend.Domain.Interfaces
{
    public interface IServiceOrderRepository : IBaseRepository<ServiceOrder>
    {
        public Task<ServiceOrder> GetBySupplierId(Guid idSupplier, CancellationToken cancellationToken);
        public Task<ServiceOrder> GetByServiceId(Guid idService, CancellationToken cancellationToken);
        public Task<ServiceOrder> GetByStatus(ERequestStatus status, CancellationToken cancellationToken);
        //Task GetServiceOrder();
    }
}