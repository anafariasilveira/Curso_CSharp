using MediatR;

public sealed record CreateServiceOrderRequest(
    Supplier Supplier,
    Service Service,
    DateTimeOffset EstimetedDate,
    EContractStatus Status,
    bool Payment
    ) : IRequest<CreateServiceOrderResponse>;