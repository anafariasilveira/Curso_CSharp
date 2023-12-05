public class LucroTest
{
    [Fact]
    public void Calcular_LucroDe45_VendaComLucro()
    {
        Lucro lucro = new ();

        decimal venda45 = lucro.Calcular(19.99M);

        Assert.Equal(28.9855M, venda45);
    }
    [Fact]
    public void Calcular_LucroDe30_VendaComLucro()
    {
        Lucro lucro = new();

        decimal venda30 = lucro.Calcular(20);

        Assert.Equal(26, venda30);
    }
}
