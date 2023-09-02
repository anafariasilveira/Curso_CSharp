using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    public static class Teste
    {
        public static string DetalhesFigura(Figura forma)
        {
            return $"Cor da figura: {forma.cor} - Área da figura: {forma.area()}";
        }
    }
}
