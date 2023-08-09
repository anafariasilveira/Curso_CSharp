Console.WriteLine("Informe seu salário:");
Console.Write("R$ ");  double salario = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de horas trabalhadas no mês:");
double horastrab =  double.Parse(Console.ReadLine());

if (horastrab <= 160)
{
    Console.WriteLine($"Seu salário é R$ {salario}.");
}
else if (horastrab > 160)
{
    double salariohoras = salario + (salario * 0.5);
    Console.WriteLine($"Seu salário é R$ {salariohoras}.");
}
Console.ReadKey();