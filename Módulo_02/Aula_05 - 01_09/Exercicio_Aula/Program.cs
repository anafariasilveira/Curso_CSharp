namespace Exercicio_Aula
{
    /* Crie um projeto Cinema
Crie uma classe Filme com Titulo, Ano, Duracao
Crie uma classe Sala com quantidadeCadeiras
Crie uma classe Sessao com private Filme, private Sala e private DataHora
No construtor da Exibicao receba a data e a sala // Injeção de dependencia via construtor
Crie um método para receber o Filme
    */
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