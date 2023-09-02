using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Triangulo : Figura
    {
        public double basetriangulo { get; set; }
        public double altura { get; set; }

        public override string cor
        {
            get => cordaforma;
            set => cordaforma = value;
        }

        public override double area()
        {
            return basetriangulo * altura;
        }
    }
}
