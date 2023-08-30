namespace Exercicio06_LMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgumaClasse lista = new();

            List<string> propriedades = Reflections.RetornaPropriedadesPublicas(lista);

            Console.WriteLine("Propriedades públicas da classe 'AlgumaClasse':");
            Console.WriteLine();

            foreach (var prop in propriedades)
            {
                Console.WriteLine(prop);
            }
        }
    }
}