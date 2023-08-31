using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_LMS
{
    public interface IAnimal
    {
        void Comer(string comida);
        void Dormir();
        string EmitirSom();
    }
}
