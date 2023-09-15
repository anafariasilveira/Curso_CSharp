using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string matricula, double salariobase) : base (nome, matricula, salariobase)
        {
            
        }
        public override double calculaSalario()
        {
            return 2 * SalarioBase;
        }
    }
}
