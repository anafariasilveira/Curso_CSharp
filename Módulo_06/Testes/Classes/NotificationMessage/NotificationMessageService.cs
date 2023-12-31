﻿namespace Classes.NotificationMessage
{
    public class NotificationService
    {
        private readonly IMessageService _messageService;

        public NotificationService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public bool NotifyUsers(List<Notification> notifications)
        {
            bool allSent = true;

            foreach (var notification in notifications)
            {
                if (!_messageService.SendMessage(notification.UserId, notification.Message))
                {
                    allSent = false;
                    break; // Se uma mensagem falhar, interrompe a notificação
                }
            }

            return allSent;
        }
    }
}
