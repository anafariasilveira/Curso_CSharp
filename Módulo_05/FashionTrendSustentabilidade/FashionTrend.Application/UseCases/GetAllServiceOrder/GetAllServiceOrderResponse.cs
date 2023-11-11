using FashionTrend.Domain.Enums;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public sealed record GetAllServiceOrderResponse
    {
        public Guid SupplierId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset EstimatedDate { get; set; }
        public ERequestStatus Status { get; set; }
    }
}