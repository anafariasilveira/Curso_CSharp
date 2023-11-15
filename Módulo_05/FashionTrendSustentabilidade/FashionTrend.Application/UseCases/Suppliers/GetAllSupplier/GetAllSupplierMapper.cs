using AutoMapper;

public class GetAllSupplierMapper : Profile
{
    public GetAllSupplierMapper()
    {
        CreateMap<Supplier, GetAllSupplierResponse>();
            // .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
    }
}