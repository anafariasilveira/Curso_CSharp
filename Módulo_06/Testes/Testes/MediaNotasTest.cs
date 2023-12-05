public class MediaNotasTest
{
    [Fact]
    public void CaclculaMedia_NotasMaiorQue07_RetornaAprovado()
    {
        List<decimal> notas = new()
        {
            7, 8, 9, 7
        };
        MediaNotas mediaNotas = new();

        string resultado = mediaNotas.CalculaMedia(notas, null);

        Assert.Contains("Parabéns, você foi aprovado!", resultado);
        Assert.Contains("7,75", resultado);
    }
    [Fact]
    public void CaclculaMedia_NotasMenorQue07_RetornaAprovadoNaRecuperação()
    {
        List<decimal> notas = new()
        {
            7, 5, 8, 7
        };
        MediaNotas mediaNotas = new();

        decimal notaRecuperacao = 8;

        string resultado = mediaNotas.CalculaMedia(notas, notaRecuperacao);

        Assert.Contains("Parabéns! Você foi aprovado na recuperação!", resultado);
        Assert.Contains("7,37", resultado);
    }
    [Fact]
    public void CaclculaMedia_NotasMenorQue07_RetornaReprovadoNaRecuperação()
    {
        List<decimal> notas = new()
        {
            7, 5, 8, 7
        };
        MediaNotas mediaNotas = new();

        decimal notaRecuperacao = 5;

        string resultado = mediaNotas.CalculaMedia(notas, notaRecuperacao);

        Assert.Contains("Infelizmente você não foi aprovado na recuperação :(.", resultado);
        Assert.Contains("5,87", resultado);
    }
}
