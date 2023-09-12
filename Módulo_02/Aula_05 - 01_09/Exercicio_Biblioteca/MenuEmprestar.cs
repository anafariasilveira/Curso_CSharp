using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public class MenuEmprestar 
    {
       
        public void EmprestarLivro()
        {
            Biblioteca biblioteca = new();

            Console.WriteLine("Informe o nome do livro desejado:");
            string titulolivro = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Diga o autor:");
            string autor = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o ano de publicação:");
            int anopubli = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe a quantidade de páginas do livro desejado:");
            int numeropags = int.Parse(Console.ReadLine());

            Livro livro = new(titulolivro, autor, anopubli, numeropags);
            biblioteca.AdicionarItem(livro);
            biblioteca.EmprestarItem(livro);
            
        }
        public void EmprestarRevista()
        {
            Biblioteca biblioteca = new();

            Console.WriteLine("Informe o nome da revista desejada:");
            string nomerevista = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe a editora:");
            string editora = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o ano de publicação:");
            int anopubli = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe a quantidade de páginas da revista desejada:");
            int numeropags = int.Parse(Console.ReadLine());

            Revista revista = new(nomerevista, editora, anopubli, numeropags);
            biblioteca.AdicionarItem(revista);
            biblioteca.EmprestarItem(revista);
        }
        public void EmprestarMidiaDigital()
        {
            Biblioteca biblioteca = new();

            Console.WriteLine("Informe o nome da mídia digital desejada:");
            string nomemidia = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o autor:");
            string autor = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o ano de publicação:");
            int anopubli = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe a quantidade de páginas da revista desejada:");
            int numeropags = int.Parse(Console.ReadLine());

            MidiaDigital midiadigital = new(nomemidia, autor, anopubli, numeropags);
            biblioteca.AdicionarItem(midiadigital);
            biblioteca.EmprestarItem(midiadigital);
        }
    }
}
