using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05_LMS
{
    public class Carro : IVeiculo
    {
        public int Gasolina { get; set; }
        public Carro(int gasolinainicial)
        {
           Gasolina = gasolinainicial;
        }

        public string Dirigir()
        {
            if (Gasolina > 0)
            {
                return $"Dirigindo";
            }
            else
            {
                return $"Reabastecer";
            }
        }

        public bool Reabastecer(int quantidadegasolina)
        {
           return true;
        }
    }
}
