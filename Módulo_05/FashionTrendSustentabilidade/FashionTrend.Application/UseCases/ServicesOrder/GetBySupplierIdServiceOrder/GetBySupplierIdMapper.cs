using AutoMapper;

public class GetBySupplierIdMapper : Profile
{
    public GetBySupplierIdMapper()
    {
        CreateMap<GetBySupplierIdRequest, ServiceOrder>();
        CreateMap<ServiceOrder, GetBySupplierIdResponse>();
    }

}