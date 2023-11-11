using FashionTrend.Domain.Enums;

namespace FashionTrend.Application.UseCases.ServicesOrder.GetAllServiceOrder
{
    public sealed record GetAllServiceOrderResponse
    {
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public EContractStatus Status { get; set; }
    }
}