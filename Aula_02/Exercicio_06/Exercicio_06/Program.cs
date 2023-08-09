    class Program
    {
        static void Main(string[] args)
        {
            int valores, dentroIntervalo = 0, foraIntervalo = 0;

            Console.Write("Digite quantos valores deseja escrever: ");
            valores = int.Parse(Console.ReadLine());

            for (int i = 0; i < valores; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    dentroIntervalo++;
                }
                else
                {
                    foraIntervalo++;
                }
            }

            Console.WriteLine($"Valores dentro do intervalo: {dentroIntervalo}");
            Console.WriteLine($"Valores fora do intervalo: {foraIntervalo}");

            Console.ReadKey();
        }
    }

