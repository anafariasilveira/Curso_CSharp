using System;
using System.ComponentModel.Design;

namespace Exercicio_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();

            Livro livro = new("Código Limpo", "Robert C. Martin", 2009, 425);
            Revista revista = new("Vogue", "Condé Nast", 2023, 50);
            MidiaDigital midiadigital = new("Use a cabeça C#", "Andrew Stelman", 2007, 738);

            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(revista);
            biblioteca.AdicionarItem(midiadigital);

            biblioteca.EmprestarItem(livro);
            biblioteca.EmprestarItem(revista);
            biblioteca.EmprestarItem(midiadigital);

            biblioteca.DevolverItem(livro);
            biblioteca.DevolverItem(revista);
            biblioteca.DevolverItem(midiadigital);
        }

    }
}