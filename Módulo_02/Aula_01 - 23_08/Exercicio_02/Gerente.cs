using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    public class Gerente : Funcionario
    {
        public double SalarioGerente = 3500;
        public override void getBonificacao()
        {
            double bonificacao = SalarioGerente * 0.25;
            Console.WriteLine($"Bonificação do gerente: {bonificacao:C}");
        }
    }
}
