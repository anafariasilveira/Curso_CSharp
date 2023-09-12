using Exercicio_Aula08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula08
{
    public class Gato : IGato
    {

        public void Comer()
        {
            Console.WriteLine("Gato comendo.");
        }
        public void Obedecer()
        {
            Console.WriteLine("Gato obedece ordens.");
        }
        public void Reproduzir()
        {
            Console.WriteLine("Gato tem filhotes.");
        }
        public void Miar()
        {
            Console.WriteLine("Miauuuuuu");
        }
    }
}
