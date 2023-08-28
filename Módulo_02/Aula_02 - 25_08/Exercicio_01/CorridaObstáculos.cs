using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_Interfaces
{
    internal class CorridaObstáculos : IExercicio
    {
        public void FazerAlongamento()
        {
            Console.WriteLine("Alongar membros inferiores");
        }
        public void FazerFortalecimento()
        {
            Console.WriteLine("Malhar membros inferiores");
        }
    }
}
