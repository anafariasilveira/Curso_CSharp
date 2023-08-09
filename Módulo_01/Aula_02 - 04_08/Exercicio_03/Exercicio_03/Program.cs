Console.WriteLine("Informe a quantidade atual do estoque:");
int qtdest = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Informe a quantidade máxima do estoque:");
int qtdmax = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Informe a quantidade mínima do estoque:");
int qtdmin = int.Parse(Console.ReadLine());
Console.WriteLine();

int qtdmed = (qtdmax + qtdmin) / 2;

Console.Clear();

Console.WriteLine($"A qunatidade média do estoque é {qtdmed}.");
Console.WriteLine();

if (qtdest >= qtdmed)
{
    Console.WriteLine("Não efetuar compra");
}
else
{
    Console.WriteLine("Efetuar compra");
}
Console.ReadKey();
