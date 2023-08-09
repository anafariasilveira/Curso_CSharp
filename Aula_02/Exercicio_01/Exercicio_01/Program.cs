/* 1- Um imposto é calculado com base na seguinte tabela: 
Até 1.200,00 isento 
de 1.201,00 a 2.500,00 10% 
de 2.501,00 a 5.000,00 15% 
acima de 5.000,00 20%. 
Implemente um programa que leia o valor base e calcule o imposto a pagar. */

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

//FAZER UM TRATAMENTO DE ERRO PARA QUANDO INSERIDO NÃO NÚMEROS