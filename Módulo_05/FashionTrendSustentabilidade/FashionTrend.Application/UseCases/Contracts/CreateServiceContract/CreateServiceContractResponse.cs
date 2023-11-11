using FashionTrend.Domain.Enums;

namespace FashionTrend.Application.UseCases.Contracts.CreateServiceContract
{
    public sealed record CreateServiceContractResponse
    {
        public Guid OrderId { get; set; }
        public Guid SupplierId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public EContractStatus Status { get; set; }
    }
}
