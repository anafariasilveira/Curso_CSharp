using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, string matricula, double salariobase) : base(nome, matricula, salariobase)
        {
            
        }
        public override double calculaSalario()
        {
            return (0.1 * SalarioBase) + SalarioBase;
        }
    }
}
