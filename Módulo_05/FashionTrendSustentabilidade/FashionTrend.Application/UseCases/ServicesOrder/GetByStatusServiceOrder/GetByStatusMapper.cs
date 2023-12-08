using AutoMapper;

public class GetByStatusMapper : Profile
{
    public GetByStatusMapper()
    {
        CreateMap<ServiceOrder, GetByStatusResponse>();
    }
}