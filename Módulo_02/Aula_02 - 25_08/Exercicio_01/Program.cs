namespace Exercicio_01_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExercicio natacao = new Natacao();

            Console.WriteLine("Natação");
            natacao.FazerAlongamento();
            natacao.FazerAlongamento();
            natacao.FazerTreino();
            natacao.FazerProva();
            Console.WriteLine();

            IExercicio corrida = new CorridaObstáculos();

            Console.WriteLine("Corrida de obstáculos");
            corrida.FazerAlongamento();
            corrida.FazerAlongamento();
            corrida.FazerTreino();
            corrida.FazerProva();
            Console.WriteLine();
        }
    }
}