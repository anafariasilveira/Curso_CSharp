using NSubstitute;

public class NotificationTest
{
    private readonly IEmailService _mockEmailService;
    private NotificationService _sut;

    public NotificationTest()
    {
        _mockEmailService = Substitute.For<IEmailService>();
        _sut = new(_mockEmailService);
    }

    [Fact]
    public void SendNotification_EmailValido_RetornaTrue()
    {
        //Arrange
        _mockEmailService.SendEmail("ana@gmail.com", "Notification", "Teste realizado com sucesso!").Returns(true);
        //Act
        bool resultado = _sut.SendNotification("ana@gmail.com", "Teste realizado com sucesso!");

        //Assert
        Assert.True(resultado);
    }
    [Fact]
    public void SendNotification_Mensagemvazia_RetornaFalse()
    {
        bool resultado = _sut.SendNotification("ana@gmail.com", "");

        Assert.False(resultado);
    }
    [Fact]
    public void SendNotification_EmailInvalido_RetornaFalse()
    {

    }
}