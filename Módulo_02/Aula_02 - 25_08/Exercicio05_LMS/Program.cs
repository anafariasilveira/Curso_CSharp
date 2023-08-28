using System.Diagnostics.Contracts;
using System.Net;
namespace Exercicio05_LMS
{
     /*
        Uma interface define um contrato.Qualquer classe que implemente esse contrato deve fornecer implementações dos membros definidos na interface.
        Crie um programa em C# que contenha uma interface IVeiculo com dois métodos, um para Dirigir do tipo void e outro para Reabastecer do tipo bool que tenha um parâmetro do tipo int com a quantidade de gasolina a ser reabastecida.
        Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a quantidade de gasolina inicial do carro e implemente os métodos Dirigir e Reabastecer do carro.
        O método Dirigir retornará "Dirigindo", se a gasolina for maior que 0. O método Reabastecer aumentará a gasolina do carro e retornará true.
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(0);

            Console.WriteLine(carro.Dirigir());
            carro.Reabastecer(10);
        }
    }
}