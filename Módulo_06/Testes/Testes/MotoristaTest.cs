public class MotoristaTest
{
    // nomeMetodo_CondicaoCenario_ComportamentoEsperado():
    Pessoa pessoa1 = new Pessoa() { Nome = "Ana", Idade = 27, PossuiHabilitaçãoB = true };
    Pessoa pessoa2 = new Pessoa() { Nome = "Hugo", Idade = 32, PossuiHabilitaçãoB = true };
    Pessoa pessoa3 = new Pessoa() { Nome = "Mara", Idade = 59, PossuiHabilitaçãoB = false };
    Pessoa pessoa4 = new Pessoa() { Nome = "Sophia", Idade = 1, PossuiHabilitaçãoB = false };
    Pessoa pessoa5 = new Pessoa() { Nome = "Luiz", Idade = 17, PossuiHabilitaçãoB = true };
    Pessoa pessoa6 = new Pessoa() { Nome = "Carolina", Idade = 18, PossuiHabilitaçãoB = true };

    [Fact]
    [Trait("DoisMotoristas", "RealizaViagem")]
    public void EncontrarMotoristas_MotoristasDisponiveis_RetornaEncontrouMotoristas()
    {
        List<Pessoa> pessoas = new List<Pessoa>() { pessoa1, pessoa2, pessoa3, pessoa4, pessoa5 };

        Motorista motorista = new();

        var resposta = motorista.EncontrarMotoristas(pessoas);

        Assert.Contains("Ana", resposta);
        Assert.Contains("Hugo", resposta);
        Assert.DoesNotContain("Mara", resposta);
        Assert.DoesNotContain("Sophia", resposta);
        Assert.DoesNotContain("Luiz", resposta);
    }
    [Fact]
    [Trait("UmMotorista", "NãoRealizaViagem")]
    public void EncontrarMotoristas_UmMotoristaDisponivel_RetornaViagemNaoRealizada()
    {
        List<Pessoa> pessoas = new List<Pessoa>() { pessoa1, pessoa3, pessoa4, pessoa5 };

        Motorista motorista = new();

        Action resposta = () => motorista.EncontrarMotoristas(pessoas);

        Assert.Throws<Exception>(resposta);
    }
    [Fact]
    [Trait("SemMotorista", "NãoRealizaViagem")]
    public void EncontrarMotoristas_NenhumMotoristaDisponivel_RetornaViagemNaoRealizada()
    {
        List<Pessoa> pessoas = new List<Pessoa>() { pessoa3, pessoa4, pessoa5 };

        Motorista motorista = new();

        Action resposta = () => motorista.EncontrarMotoristas(pessoas);

        Assert.Throws<Exception>(resposta);
    }
    [Fact]
    [Trait("EncontrouMotorista", "RealizaViagem")]
    public void EncontrarMotoristas_Motorista18Anos_RetornaEncontrouMotoristas()
    {
        List<Pessoa> pessoas = new List<Pessoa>() { pessoa1, pessoa6 };

        Motorista motorista = new();

        var resposta = motorista.EncontrarMotoristas(pessoas);

        Assert.Contains("Ana", resposta);
        Assert.Contains("Carolina", resposta);
        Assert.DoesNotContain("Mara", resposta);
        Assert.DoesNotContain("Sophia", resposta);
        Assert.DoesNotContain("Luiz", resposta);
    }
}