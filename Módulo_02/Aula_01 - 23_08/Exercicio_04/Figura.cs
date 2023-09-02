using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    public abstract class Figura
    {
        public abstract string cor { get; set; }
        protected string cordaforma;
        public abstract double area();

    }
}
