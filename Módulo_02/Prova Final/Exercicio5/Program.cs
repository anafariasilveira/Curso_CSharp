namespace Exercicio5;
class Program
{
    static void Main(string[] args)
    {
        // testes das modificações

        IDesconto novo = new ClienteNovo();
        CalculadoraDesconto descontonovo = new(novo);
        decimal calculoN = descontonovo.CalcularDesconto(50);

        IDesconto premium = new ClientePremium();
        CalculadoraDesconto descontopremium = new(premium);
        decimal calculoP = descontopremium.CalcularDesconto(50);

        IDesconto vip = new ClienteVIP();
        CalculadoraDesconto descontovip = new(vip);
        decimal calculoV = descontovip.CalcularDesconto(50);

        Console.WriteLine($"Descontos:\n\n" +
            $"Novo: {calculoN}\n" +
            $"Premium: {calculoP}\n" +
            $"VIP: {calculoV}");



    }
}
