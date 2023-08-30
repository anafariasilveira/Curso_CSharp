using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06_LMS
{
    public static class Reflections
    {
        public static List<string> RetornaPropriedadesPublicas(object obj)
        {
            List<string> lista = new();

            PropertyInfo[] propriedades = obj.GetType().GetProperties();

            foreach (var propriedade in propriedades)
            {
                lista.Add(propriedade.Name);
            }
            return lista;
        }
    }
}
