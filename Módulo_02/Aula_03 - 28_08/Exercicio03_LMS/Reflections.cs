using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercicio03_LMS
{
    public static class Reflections
    {
        public static string ConcatStringMembers(object TestObject)
        {
            if (TestObject == null)
            {
                return "";
            }
        
            MethodInfo[] metodos = TestObject.GetType().GetMethods();
            StringBuilder builder = new StringBuilder();

            foreach (MethodInfo metodo in metodos)
            {
                if (metodo.ReturnType == typeof(string) && metodo.GetParameters().Length == 0)
                {
                    string metodoName = metodo.Name;
                    object metodoResult = metodo.Invoke(TestObject, null);
                    string metodoValue = metodoResult != null ? metodoResult.ToString() : "null";

                    builder.AppendLine($"{metodoName}: {metodoValue}");
                }
            }
            return metodos.ToString();
        }
    }
}
