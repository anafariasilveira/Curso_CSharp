using System.Collections.Generic;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        // teste generics

        string[] cidades = { "Vassouras", "Paracambi", "Rio de Janeiro", "Cascavel", "Maringá" };

        List<string> ordemcidades = MinhaLista.RetornaListaOrdenada(cidades);

        Console.WriteLine(string.Join(",", ordemcidades));
    }
}
