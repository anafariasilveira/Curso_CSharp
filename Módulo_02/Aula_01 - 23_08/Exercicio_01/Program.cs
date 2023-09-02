namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futebol fut = new();

            Console.WriteLine(fut.IniciarJogo());
            Console.WriteLine(fut.FinalizarJogo());
            Console.WriteLine(fut.ExibirDescricao());
        }
    }
}