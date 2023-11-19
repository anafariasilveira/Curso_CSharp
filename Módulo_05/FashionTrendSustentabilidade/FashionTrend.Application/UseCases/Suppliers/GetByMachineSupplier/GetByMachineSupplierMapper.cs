using AutoMapper;

public class GetByMachineSupplierMapper : Profile
{
    public GetByMachineSupplierMapper()
    {
        CreateMap<GetByMachineSupplierRequest, Supplier>();
        CreateMap<Supplier, GetByMachineSupplierResponse>();
    }
}