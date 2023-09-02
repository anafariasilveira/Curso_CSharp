using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    public class SecretariaAgencia : Secretaria
    {
        public double SalarioAgencia = 1800;
        public override void getBonificacao()
        {
            double bonificacao = SalarioAgencia * 0.15;
            Console.WriteLine($"Bonificação da Secretaria da agência: {bonificacao:C}");
        }
    }
}
