using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class CalculadoraDesconto
    {
        private readonly IDesconto Desconto;
        public CalculadoraDesconto(IDesconto desconto)
        {
            Desconto = desconto;
        }
        public decimal CalcularDesconto(decimal valorTotal)
        {
            return Desconto.Desconto(valorTotal);
        }
    }
}
