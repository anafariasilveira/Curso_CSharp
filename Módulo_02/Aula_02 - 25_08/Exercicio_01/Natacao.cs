using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_25_08
{
    public class Natacao : IExercicio
    {
        public void FazerFortalecimento()
        {
            Console.WriteLine("Malhar membros superiores e inferiores");
        }
        public void FazerAlongamento()
        {
            Console.WriteLine("Alongar membros superiores e inferiores");
        }
    }
}
