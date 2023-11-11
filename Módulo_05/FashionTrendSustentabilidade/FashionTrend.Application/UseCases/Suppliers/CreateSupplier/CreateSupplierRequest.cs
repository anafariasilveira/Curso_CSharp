using FashionTrend.Domain.Enums;
using MediatR;

namespace FashionTrend.Application.UseCases.Suppliers.CreateSupplier
{
    public sealed record CreateSupplierRequest(
        string Name,
        string Email,
        string Password,
        List<EMaterial> Materials,
        List<ESewingMachine> SewingMachines) : IRequest<CreateSupplierResponse>;
}