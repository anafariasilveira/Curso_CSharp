using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new();

            triangulo.cor = "Rosa";
            triangulo.basetriangulo = 10;
            triangulo.altura = 5;

            Console.WriteLine(Teste.DetalhesFigura(triangulo));
        }
    }
}