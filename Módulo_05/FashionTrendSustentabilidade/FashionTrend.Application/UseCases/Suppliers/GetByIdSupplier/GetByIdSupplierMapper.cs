using AutoMapper;

public class GetByIdSupplierMapper : Profile
{
    public GetByIdSupplierMapper()
    {
        CreateMap<GetByIdSupplierRequest, Supplier>();
        CreateMap<Supplier, GetByIdSupplierResponse>();
    }

}