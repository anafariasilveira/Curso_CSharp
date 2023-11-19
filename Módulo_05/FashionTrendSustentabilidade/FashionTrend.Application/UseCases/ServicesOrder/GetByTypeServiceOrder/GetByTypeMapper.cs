using AutoMapper;

public class GetByTypeMapper : Profile
{
    public GetByTypeMapper()
    {
        CreateMap<GetByTypeRequest, ServiceOrder>();
        CreateMap<ServiceOrder, GetByTypeResponse>();
    }

}