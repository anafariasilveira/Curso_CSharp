using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ServiceOrderController : ControllerBase
{
    IMediator _mediator;

    public ServiceOrderController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateServiceOrderRequest request)
    {
        var serviceOrder = await _mediator.Send(request);
        return Ok(serviceOrder);

    }
    [HttpGet]
    public async Task<ActionResult<List<GetAllServiceOrderResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllServiceOrderRequest(), cancellationToken);
        return Ok(response);
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateServiceOrderResponse>> Update(
                                        Guid id, UpdateServiceOrderRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}