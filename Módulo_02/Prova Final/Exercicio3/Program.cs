namespace Exercicio3;
class Program
{
    static void Main(string[] args)
    {
        // teste reflection


        ClasseTeste teste = new();
        List<string> nomedosmetodos = Reflection.RetornaMetodos(teste);

        foreach (string nomemetodo in nomedosmetodos)
        {
            Console.WriteLine(nomemetodo);
        }
    }
}
