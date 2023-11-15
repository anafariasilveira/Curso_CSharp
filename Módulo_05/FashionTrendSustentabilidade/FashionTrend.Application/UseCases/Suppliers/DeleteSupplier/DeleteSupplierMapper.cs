using AutoMapper;

public class DeleteSupplierMapper : Profile
{
    public DeleteSupplierMapper()
    {
        CreateMap<CreateSupplierRequest, Supplier>();
        CreateMap<Supplier, DeleteSupplierResponse>();
    }

}