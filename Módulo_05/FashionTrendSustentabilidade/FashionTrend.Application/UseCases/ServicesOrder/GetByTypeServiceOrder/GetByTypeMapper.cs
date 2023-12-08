using AutoMapper;
using System.Collections.Generic;

public class GetByTypeMapper : Profile
{
    public GetByTypeMapper()
    {
        CreateMap<ServiceOrder, GetByTypeResponse>();
    }

}