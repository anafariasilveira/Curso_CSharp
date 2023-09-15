namespace Exercicio1;
class Program
{
    static void Main(string[] args)
    {
        // teste calculos

        Gerente gerente = new("Ana Faria Silveira", "123456", 5000);
        Assistente assistente = new("Sophia Silveira", "987654", 2000);
        Vendedor vendedor = new("Hugo Silveira", "456789", 4000);

        Console.WriteLine($"O gerente recebe R$: {gerente.calculaSalario()}\n" +
            $"O assistente recebe R$: {assistente.calculaSalario()}\n" +
            $"O vendedor recebe R$: {vendedor.calculaSalario()}");
    }
}
