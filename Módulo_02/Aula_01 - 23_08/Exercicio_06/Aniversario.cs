using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class Aniversario : CartaoWeb
    {
        public Aniversario(string destinatario) : base(destinatario)
        {
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz aniversário, {Destinatario}!");
        }
    }
}
