using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MessageConsumer : ControllerBase
{
    IMediator _mediator;

    public MessageConsumer(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ConsumerMessageRequest request)
    {
        var message = await _mediator.Send(request);
        return Ok(message);
    }
}