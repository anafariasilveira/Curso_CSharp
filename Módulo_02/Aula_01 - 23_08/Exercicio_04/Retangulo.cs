using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Retangulo : Figura
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public override string cor
        {
            get => cordaforma;
            set => cordaforma = value;
        }

        public override double area()
        {
            return lado1 * lado2;
        }
    }
}
