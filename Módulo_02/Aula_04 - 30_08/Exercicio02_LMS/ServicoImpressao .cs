using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_LMS
{
    public static class ServicoImpressao
    {
        public static string ImprimeValorETipo<T>(T valor)
        {
            string tipo = typeof(T).Name;

            if (tipo == "Int32")
            {
                tipo = "Int";
            }
            return $"{tipo}: {valor}";
        }
    }
}
