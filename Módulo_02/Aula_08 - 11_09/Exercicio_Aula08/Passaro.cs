using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Aula08.Interfaces;

namespace Exercicio_Aula08
{
    public class Passaro :  IPassaro
    {
        public void Comer()
        {
            Console.WriteLine("Pássado comendo.");
        }
        public void Reproduzir()
        {
            Console.WriteLine("Pássaro coloca ovos.");
        }
        public void Voar()
        {
            Console.WriteLine("Pássaro voa.");
        }
    }
}
