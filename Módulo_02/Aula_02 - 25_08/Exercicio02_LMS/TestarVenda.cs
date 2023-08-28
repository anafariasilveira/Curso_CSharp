using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_LMS
{
    public static class TestarVenda
    {
        public static string DetalhesVenda(Venda venda)
        {
            return $"Data da venda: {venda.dataString()}\n" +
                $"Produto: {venda.Produto.Nome}\n" +
                $"Valor do produto: R$ {venda.Produto.Valor}\n" +
                $"Vencimento: {venda.Produto.dataString()}\n";
        }
    }
}
