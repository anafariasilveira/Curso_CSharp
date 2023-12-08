using AutoMapper;

public class GetBySupplierIdMapper : Profile
{
    public GetBySupplierIdMapper()
    {
        CreateMap<ServiceOrder, GetBySupplierIdResponse>();
    }
}