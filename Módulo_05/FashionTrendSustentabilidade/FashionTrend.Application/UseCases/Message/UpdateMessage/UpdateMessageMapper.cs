using AutoMapper;

public class UpdateMessageMapper : Profile
{
    public UpdateMessageMapper()
    {
        CreateMap<UpdateMessageRequest, Message>();
        CreateMap<Message, UpdateMessageResponse>();
    }

}