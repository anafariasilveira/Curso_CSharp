namespace Exercicio_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme novofilme = new("As Branquelas", 2004, 109);

            Sala novasala = new();

            novasala.QuantidadeCadeiras = 100;
            novasala.Numero = 2;

            Sessao novasessao = new(novasala, new DateTime(2023,08,29,14,30,0));

            novasessao.NomeFilme(novofilme);
            Console.WriteLine(novasessao);

        }
    }
}
