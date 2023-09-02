using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    public class Diretor : Gerente
    {
        public override void getBonificacao()
        {
            Console.WriteLine($"Bonificação ddiretor: {base.getBonificacao}");
        }

    }
}
