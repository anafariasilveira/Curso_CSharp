using FashionTrend.Domain.Enums;

namespace FashionTrend.Domain.Entities
{
    public class ServiceOrder : BaseEntity
    {
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public EContractStatus Status { get; set; }
    }
}
