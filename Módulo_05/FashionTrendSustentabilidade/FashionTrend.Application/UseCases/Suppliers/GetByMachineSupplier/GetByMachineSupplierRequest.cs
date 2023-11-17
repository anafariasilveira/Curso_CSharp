using MediatR;

public sealed record GetByMachineSupplierRequest(List<ESewingMachine> Machine) : 
                                                                        IRequest<GetByMachineSupplierResponse>;