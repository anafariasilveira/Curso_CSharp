using System.Diagnostics.Contracts;
using System.Net;
namespace Exercicio05_LMS
{
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