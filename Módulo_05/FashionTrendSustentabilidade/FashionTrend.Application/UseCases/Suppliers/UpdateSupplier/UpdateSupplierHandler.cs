using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class UpdateSupplierHandler : IRequestHandler<UpdateSupplierRequest, UpdateSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<UpdateSupplierHandler> _logger;

    public UpdateSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper, ILogger<UpdateSupplierHandler> logger)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }
    public async Task<UpdateSupplierResponse> Handle(UpdateSupplierRequest command, CancellationToken cancellationToken)
    {
        try
        {
            var supplier = await _supplierRepository.Get(command.Id, cancellationToken);

            if (supplier is null)
                throw new ArgumentException("Supplier não encontrado.");

            supplier.Name = command.Name;
            supplier.Email = command.Email;
            supplier.Password = command.Password;
            supplier.SewingMachines = command.SewingMachines;
            supplier.Materials = command.Materials;

            _supplierRepository.Update(supplier);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateSupplierResponse>(supplier);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método de Update do Supplier.");
            throw;
        }
    }
}