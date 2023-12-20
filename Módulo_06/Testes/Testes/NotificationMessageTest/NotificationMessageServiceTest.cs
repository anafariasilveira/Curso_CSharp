using Classes.NotificationMessage;
using NSubstitute;

namespace Testes.NotificationMessageTest
{
    public class NotificationMessageServiceTest
    {
        private readonly IMessageService _mockMessageService;
        private NotificationService _sut;

        public NotificationMessageServiceTest()
        {
            _mockMessageService = Substitute.For<IMessageService>();
            _sut = new(_mockMessageService);
        }
        [Fact]
        public void NotifyUsers_EnvioSucesso_RetornaTrue()
        {
            List<Notification> notifications = new List<Notification>()
            {
                new Notification { Message = "Olá!", UserId = "01"}
            };

            _mockMessageService.SendMessage("01", "Olá!").Returns(true);

            bool resultado = _sut.NotifyUsers(notifications);

            Assert.True(resultado);
        }
        [Fact]
        public void NotifyUsers_EnvioFalho_RetornaTrue()
        {
            List<Notification> notifications = new List<Notification>()
            {
                new Notification { Message = "Olá!", UserId = "01"}
            };

            _mockMessageService.SendMessage(Arg.Any<string>(), Arg.Any<string>()).Returns(false);

            bool resultado = _sut.NotifyUsers(notifications);

            Assert.False(resultado);
        }
        [Fact]
        public void NotifyUsers_EnvioVazio_RetornaFalso()
        {
            List<Notification> notifications = new List<Notification>();

            bool resultado = _sut.NotifyUsers(notifications);

            Assert.True(resultado);
        }
    }
}