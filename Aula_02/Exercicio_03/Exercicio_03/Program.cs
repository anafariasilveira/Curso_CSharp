/* 3- Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e quantidade 
mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade média = 
quantidade máxima + quantidade mínima)/2). Se a quantidade em estoque for maior ou igual a quantidade 
média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'. */

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
