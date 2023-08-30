using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05_LMS
{
    public class Utils
    {
        public static bool IsClass(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj), "Object cannot be null.");

            return obj.GetType().IsClass;
        }
    }
}
