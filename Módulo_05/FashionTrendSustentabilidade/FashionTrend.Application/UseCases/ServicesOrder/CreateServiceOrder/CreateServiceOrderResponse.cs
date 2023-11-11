using FashionTrend.Domain.Enums;

namespace FashionTrend.Application.UseCases.ServicesOrder.CreateServiceOrder
{
    public sealed record CreateServiceOrderResponse
    {
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public EContractStatus Status { get; set; }
    }
}