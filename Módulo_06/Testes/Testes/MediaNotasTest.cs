public class MediaNotasTest
{
    [Fact(DisplayName = "Aprovado")]
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
    [Fact(DisplayName = "Aprovado na Recuperação")]
    public void CaclculaMedia_NotasMenorQue07_RetornaAprovadoNaRecuperação()
    {
        List<decimal> notas = new()
        {
            7, 5, 8, 7
        };
        MediaNotas mediaNotas = new();

        decimal notaRecuperacao = 10;

        string resultado = mediaNotas.CalculaMedia(notas, notaRecuperacao);

        Assert.Contains("Parabéns! Você foi aprovado na recuperação!", resultado);
        Assert.Contains("8,37", resultado);
    }
    [Fact(DisplayName = "Reprovado na Recuperação")]
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
    [Fact(DisplayName = "Nota 7 Aprovado")]
    public void CalculaMedia_NotaIgualA07_RetornaAprovado()
    {
        List<decimal> notas = new()
        {
            7, 7, 7, 7
        };
        MediaNotas mediaNotas = new();

        string nota7 = mediaNotas.CalculaMedia(notas, null);

        Assert.Contains("Parabéns, você foi aprovado!", nota7);
    }
    [Fact(DisplayName = "Nota 7 Aprovado na Recuperação")]
    public void CalculaMedia_NotaRecuperacao7_RetornaAprovadoNaRecuperacao()
    {
        List<decimal> notas = new()
        {
            7, 7, 7, 6
        };
        MediaNotas mediaNotas = new();

        decimal notaRecuperacao = 7.25M;

        string nota7 = mediaNotas.CalculaMedia(notas, notaRecuperacao);

        Assert.Contains("Parabéns! Você foi aprovado na recuperação!", nota7);
    }
}
