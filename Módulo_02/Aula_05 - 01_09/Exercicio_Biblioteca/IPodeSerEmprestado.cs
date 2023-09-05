using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public interface IPodeSerEmprestado
    {
        string Emprestar();
        string Devolver(DateTime datadevolucao);
    }
}
