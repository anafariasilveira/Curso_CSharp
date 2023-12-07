public class MeiaCinemaTest
{
    [Theory]
    [InlineData(true, false, false, false)]
    [Trait("ConcederMeiaEntrada", "VerdadeiroParaEstudante")]
    public void VerificaMeiaCinema_VerdadeiroParaEstudante_RetornaPossuiMeiaEntrada(bool estudante, bool doadorDeSangue, bool trabalhadorPrefeitura, bool contratoPrefeitura)
    {
        MeiaCinema meiaCinema = new();

        bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(false, true, false, false)]
    [Trait("ConcederMeiaEntrada", "VerdadeiroParaDoadorDeSangue")]
    public void VerificaMeiaCinema_VerdadeiroParaDoadorDeSangue_RetornaPossuiMeiaEntrada(bool estudante, bool doadorDeSangue, bool trabalhadorPrefeitura, bool contratoPrefeitura)
    {
        MeiaCinema meiaCinema = new();

        bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(false, false, true, false)]
    [Trait("ConcederMeiaEntrada", "TrabalhadorSemContrato")]
    public void VerificaMeiaCinema_TrabalhadorSemContrato_RetornaNaoPossuiMeiaEntrada(bool estudante, bool doadorDeSangue, bool trabalhadorPrefeitura, bool contratoPrefeitura)
    {
        MeiaCinema meiaCinema = new();

        bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

        Assert.False(resultado);
    }

    [Theory]
    [InlineData(false, false, true, true)]
    [Trait("ConcederMeiaEntrada", "TrabalhadorComContrato")]
    public void VerificaMeiaCinema_TrabalhadorComContrato_RetornaPossuiMeiaEntrada(bool estudante, bool doadorDeSangue, bool trabalhadorPrefeitura, bool contratoPrefeitura)
    {
        MeiaCinema meiaCinema = new();

        bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

        Assert.True(resultado);
    }
    [Theory]
    [InlineData(false, false, false, false)]
    [Trait("ConcederMeiaEntrada", "NãoTemAsCondições")]
    public void VerificaMeiaCinema_SemCondicoesParaMeiaEntrada_RetornaNaoPossuiMeiaEntrada(bool estudante, bool doadorDeSangue, bool trabalhadorPrefeitura, bool contratoPrefeitura)
    {
        MeiaCinema meiaCinema = new();

        bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

        Assert.False(resultado);
    }
}