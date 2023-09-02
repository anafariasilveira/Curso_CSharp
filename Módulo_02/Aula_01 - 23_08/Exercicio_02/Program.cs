using System.IO;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecretariaAdministrativa sa = new();
            Console.WriteLine(sa.getBonificacao);

            SecretariaAgencia sag = new();
            Console.WriteLine(sag.getBonificacao);

            Presidente presi = new();
            Console.WriteLine(presi.getBonificacao);

            Gerente ger = new();
            Console.WriteLine(ger.getBonificacao);

            Diretor dir = new();
            Console.WriteLine(dir.getBonificacao);



        }
    }
}