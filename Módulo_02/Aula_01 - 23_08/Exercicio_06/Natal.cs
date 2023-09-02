using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class Natal : CartaoWeb
    {
        public Natal(string destinatario) : base(destinatario)
        {
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz natal, {Destinatario}!");
        }
    }
}
