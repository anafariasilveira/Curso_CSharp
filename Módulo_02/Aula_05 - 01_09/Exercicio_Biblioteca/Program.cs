namespace Exercicio_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new ("Código Limpo", "Robert C. Martin", 2009, 425);

            Console.WriteLine(livro.Emprestar());
            Console.WriteLine(livro.Devolver());
        }
    }
}