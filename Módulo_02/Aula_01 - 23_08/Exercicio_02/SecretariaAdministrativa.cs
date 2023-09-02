using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    public class SecretariaAdministrativa : Secretaria
    {
        public double SalarioAdministrativo = 1500;

        public override void getBonificacao()
        {
            double bonificacao = SalarioAdministrativo * 0.1;
            Console.WriteLine($"Bonificação da Secretaria administrativa: {bonificacao:C}");

        }
    }
}
