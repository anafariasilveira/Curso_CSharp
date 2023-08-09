Console.WriteLine("Digite seu salário:");
Console.Write("R$ "); double salario = double.Parse(Console.ReadLine());

if (salario <= 1200)
{
    Console.WriteLine("Você está isento de imposto.");
}
else if (salario >= 1201 && salario <= 2500)
{
    double salarioimp1 = salario * 0.01;
    Console.WriteLine($"Você paragará R$ {salarioimp1} de imposto.");
}
else if (salario >= 2501 && salario <= 5000)
{
    double salarioimp2 = salario * 0.015;
    Console.WriteLine($"Você pagará R$ {salarioimp2} de imposto.");
}
else if (salario > 5000)
{
    double salarioimp3 = salario * 0.02;
    Console.WriteLine($"Você pagará R$ {salarioimp3} de imposto");
}
Console.ReadKey();