namespace Exercicio01_LMS
{
    /* 
       Considerando a classe abstrata AnimalBase e a classe Cachorro, realize a conversão da classe abstrata para uma interface chamada IAnimal. Essa nova interface deverá ser implementada pela classe Cachorro. 
     */
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