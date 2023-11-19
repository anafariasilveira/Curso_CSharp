using MediatR;

public sealed record UpdateMessageRequest(
        string topic, string sender, string receiver, string content) : IRequest<UpdateMessageResponse>;