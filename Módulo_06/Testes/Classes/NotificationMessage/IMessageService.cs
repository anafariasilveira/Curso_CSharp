namespace Classes.NotificationMessage
{
    public interface IMessageService
    {
        bool SendMessage(string userId, string message);
    }
}
