using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class ClienteVIP : IDesconto
    {
        public decimal Desconto(decimal valorTotal)
        {
            return valorTotal * 0.5m;
        }
    }
}
