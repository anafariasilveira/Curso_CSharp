using FashionTrend.Domain.Entities;
using AutoMapper;

namespace FashionTrend.Application.UseCases.Suppliers.CreateSupplier
{
    public class CreateSupplierMapper : Profile
    {
        public CreateSupplierMapper()
        {
            CreateMap<CreateSupplierRequest, Supplier>();
            CreateMap<Supplier, CreateSupplierResponse>();
        }

    }
}
