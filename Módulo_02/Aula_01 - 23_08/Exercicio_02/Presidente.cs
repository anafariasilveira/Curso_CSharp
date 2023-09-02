using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    public class Presidente : Funcionario
    {
        public double SalarioPresidente = 5000;
        public override void getBonificacao()
        {
            double bonificacao = SalarioPresidente * 0.30;
            Console.WriteLine($"Bonificação dp presidente: {bonificacao:C}");
        }
    }
}
