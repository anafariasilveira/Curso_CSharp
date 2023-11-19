using MediatR;

public sealed record GetByMachineSupplierRequest(ESewingMachine Machine) : 
                                                                        IRequest<IEnumerable<GetByMachineSupplierResponse>>;