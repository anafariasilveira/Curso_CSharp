using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercicio01_LMS
{
    public static class Reflections
    {
        public static string RetornaNome(object obj)
        {
            PropertyInfo[] propriedades = obj.GetType().GetProperties();
            Console.WriteLine($"O tipo {obj.GetType().Name} tem {propriedades.Length} propriedade pública.");
            Console.WriteLine();

            foreach (var propriedade in propriedades)
            {
                Console.WriteLine($"Tenho a propriedade pública {propriedade.Name} do tipo {propriedade.PropertyType.Name} e seu valor é {propriedade.GetValue(obj)}");
            }
            return obj.GetType().Name;

        }
    }
}
