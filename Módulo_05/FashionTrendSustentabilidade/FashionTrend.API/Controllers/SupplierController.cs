using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SupplierController : ControllerBase
{
    IMediator _mediator;

    public SupplierController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSupplierRequest request)
    {
        var supplier = await _mediator.Send(request);
        return Ok(supplier);
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateSupplierResponse>> Update(
                                        Guid id, UpdateSupplierRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpGet]
    public async Task<ActionResult<List<GetAllSupplierResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllSupplierRequest(), cancellationToken);
        return Ok(response);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<GetSupplierResponse>> Get(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var request = new GetSupplierRequest(id.Value);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var deleteRequest = new DeleteSupplierRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
    }
    [HttpGet("{machine}", Name = "GetByMachine")]
    public async Task<ActionResult<GetByMachineSupplierResponse>> GetByMachine
                                            (ESewingMachine machine, CancellationToken cancellationToken)
    {
        var machineRequest = new GetByMachineSupplierRequest(machine);
        var response = await _mediator.Send(machineRequest, cancellationToken);
        return Ok(response);
    }
}