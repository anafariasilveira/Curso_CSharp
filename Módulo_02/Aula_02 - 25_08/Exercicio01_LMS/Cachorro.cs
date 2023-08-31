using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_LMS
{
    public class Cachorro : IAnimal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }

        public void Comer(string comida)
        {
            Console.WriteLine($"O cachorro está comendo.");
        }
        public void Dormir()
        {
            Console.WriteLine("O cahcorro dorme durante a noite.");
        }
        public string EmitirSom()
        {
            return "AuAu";
        }
    }
}
