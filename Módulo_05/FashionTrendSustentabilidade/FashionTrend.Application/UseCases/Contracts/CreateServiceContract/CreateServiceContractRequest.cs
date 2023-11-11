using FashionTrend.Domain.Enums;
using MediatR;

namespace FashionTrend.Application.UseCases.Contracts.CreateServiceContract
{
    public sealed record CreateServiceContractRequest(
        Guid OrderId,
        Guid SupplierId,
        DateTimeOffset StartDate,
        DateTimeOffset EndDate,
        EContractStatus Status) : IRequest<CreateServiceContractResponse>;
}