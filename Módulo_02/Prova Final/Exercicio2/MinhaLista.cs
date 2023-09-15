using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public static class MinhaLista
    {
        public static List<T> RetornaListaOrdenada<T>(T[] values)
        {
            var lista = new List<T>(values);
            lista.Sort();

            return lista;

        }
    }
}
