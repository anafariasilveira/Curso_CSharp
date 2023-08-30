using System.Reflection;
using System.Net.WebSockets;

namespace Exercicio_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chocolate choc = new("Lacta", "Ao leite", "Diamante Negro");

            choc.ImprimeReflection(choc);

        }
    }
}