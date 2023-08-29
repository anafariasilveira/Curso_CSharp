namespace Exercicio01_LMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro(); // se eu quiser pegar as propriedades da classe, eu tenho que iniciar a instancia com o nome dela. Vai puxar os métodos da interface e o restante da classe.

            cachorro.Comer("Ração");
            cachorro.Dormir();
            Console.WriteLine(cachorro.EmitirSom());
            cachorro.Nome = "Tobby";
            cachorro.Raca = "Vira Lata";

        }
    }
}