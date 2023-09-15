using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercicio3
{
    public static class Reflection
    {
        public static List<string> RetornaMetodos(object objeto)
        {
            List<string> nomedosmetodos = new();

            MethodInfo[] metodo = objeto.GetType().GetMethods();

            foreach (MethodInfo metodos in metodo) 
            {
                nomedosmetodos.Add(metodos.Name);
            }
            return nomedosmetodos;
        }
    }
}
