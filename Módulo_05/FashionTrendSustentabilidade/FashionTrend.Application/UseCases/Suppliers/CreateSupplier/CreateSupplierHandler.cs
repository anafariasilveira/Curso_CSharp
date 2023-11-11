using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases.Suppliers.CreateSupplier
{
    public class CreateSupplierHandler : IRequestHandler<CreateSupplierRequest, CreateSupplierResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public CreateSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<CreateSupplierResponse> Handle(CreateSupplierRequest request, CancellationToken cancellationToken)
        {
            var supplier = _mapper.Map<Supplier>(request);

            _supplierRepository.Create(supplier);

            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateSupplierResponse>(supplier);
        }
    }
}