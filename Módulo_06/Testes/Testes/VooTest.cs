public class VooTest
{
    Voo voo = new("Boeing 747", "C234", DateTime.Now);

    [Fact]
    public void DefinirAsVagasDisponiveis_NovoVoo_Retorna100Assentos()
    {
        int resultado = voo.QuantidadeVagasDisponivel();

        Assert.Equal(100, resultado);
    }
    [Fact]
    public void ProximoLivre_NovoVooComAssentosLivres_RetornaProximoAssentoLivre()
    {
        int assento = voo.ProximoLivre();

        Assert.True(voo.OcupaAssento(assento));
    }
    [Fact]
    public void AssentoDisponivel_AssentosDisponiveisNoVoo_RetornaTrueSeAssentosDisponiveis()
    {
        var assentosDisponiveis = voo.AssentoDisponivel(1);

        Assert.True(assentosDisponiveis);
    }
    [Fact]
    public void AssentoDisponivel_SemAssentosDisponiceisNoVoo_RetornaFalseSeAssentosNaoDisponiveis()
    {
        voo.OcupaAssento(100);
        var assentosDisponiveis = voo.AssentoDisponivel(100);

        Assert.False(assentosDisponiveis);
    }
    [Fact]
    public void OcupaAssento_OcupaCorretamentoOAssento_RetornaTrueAssentoOcupado()
    {
        var assentoLivre = voo.OcupaAssento(30);

        Assert.True(assentoLivre);
    }
    [Fact]
    public void OcupaAssento_OcupaAssentoJaOcupado_RetornaFalseAssentoOcupado()
    {
        voo.OcupaAssento(30);
        var assentoLivre = voo.OcupaAssento(30);

        Assert.False(assentoLivre);
    }
    [Fact]
    public void ExibeInformacoesVoo_InformacoesDoVoo_RetornaAsInformacoesDoVoo()
    {
        var informacoes = voo.ExibeInformacoesVoo();

        Assert.Contains("Boeing 747", informacoes);
        Assert.Contains("C234", informacoes);
        //Assert.Contains($"dia e hora {voo.DataHora}", informacoes);
    }
}

