using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class DiaDosNamorados : CartaoWeb
    {
        public DiaDosNamorados(string destinatario) : base(destinatario)
        {
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz dia dos namorados, {Destinatario}!");
        }
    }
}
