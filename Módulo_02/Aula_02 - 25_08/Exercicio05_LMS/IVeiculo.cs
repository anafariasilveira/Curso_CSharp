using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05_LMS
{
    public interface IVeiculo
    {
        string Dirigir();
        bool Reabastecer(int quantidadeabastecer);
    }
}
