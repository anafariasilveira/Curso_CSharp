using System;
using System.ComponentModel.Design;

namespace Exercicio_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();

            Console.WriteLine($"Bem vindo! {Environment.NewLine}" +
                $"O que deseja pegar emprestado?\n" +
                $"1- Livro \n" +
                $"2- Revista \n" +
                $"3- Mídia Digital\n");
            Console.Write("Opção escolhida: "); int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool escolha = true;

            while (escolha)
            {
                if (opcao == 1)
                {
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
                    DateTime dataemprestimo = DateTime.Now;
                    biblioteca.EmprestarItem(titulolivro);
                }
                if (opcao == 2)
                {
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
                    DateTime dataemprestimo = DateTime.Now;
                    revista.Emprestar(dataemprestimo);
                }
                if (opcao == 3)
                {
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
                    DateTime dataemprestimo = DateTime.Now;
                    midiadigital.Emprestar(dataemprestimo);
                }
                if (escolha == false)
                {
                    Console.WriteLine("Digite uma opção válida.");
                    
                }
            } 


        }
    }
}