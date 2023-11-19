using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class MessageControler : ControllerBase
{
    IMediator _mediator;

    public MessageControler(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMessageRequest request)
    {
        var message = await _mediator.Send(request);
        return Ok(message);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(UpdateMessageRequest request, CancellationToken cancellationToken) 
    { 
        var response = await _mediator.Send(request, cancellationToken); 
        return Ok(response); 
    }

}