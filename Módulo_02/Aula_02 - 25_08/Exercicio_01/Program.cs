namespace Exercicio_01_25_08
{
    /* Crie uma interface Exercicio contendo os contratos para:
                FazerProva - implementado
                FazerTreino - implementado
                FazerFortalecimento - contrato
                FazerAlongamento - contrato

                Crie uma classe Natacao que implemente os métodos
                Fortalecimento -> Malhar membros superiores e inferiores
                Alongamento -> Alongar membros superiores e inferiores 

                Crie uma classe CorridaObstaculos que implemente os métodos
                Fortalecimento -> Malhar membros inferiores
                Alongamento -> Alongar membros inferiores

                Crie uma classe de teste
    */
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