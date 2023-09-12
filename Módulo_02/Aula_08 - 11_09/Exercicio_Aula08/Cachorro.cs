using Exercicio_Aula08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula08
{
    public class Cachorro : ICachorro
    {
        public void Comer()
        {
            Console.WriteLine("Cachorro comendo.");
        }

        public void Obedecer()
        {
            Console.WriteLine("Cachorro obedece ordens.");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Cachorro tem filhotes.");
        }
        public void Latir()
        {
            Console.WriteLine("AuAu");
        }
    }
}
