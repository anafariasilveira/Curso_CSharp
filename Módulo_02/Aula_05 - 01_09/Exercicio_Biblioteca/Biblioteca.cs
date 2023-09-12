using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public class Biblioteca
    {
        private List<IPodeSerEmprestado> emprestimo = new ();


        public void AdicionarItem(IPodeSerEmprestado item)
        {
            emprestimo.Add(item);
        }

        public void EmprestarItem(IPodeSerEmprestado item)
        {
            if (emprestimo.Contains(item))
            {
                item.Emprestar();
                emprestimo.Remove(item);
            }
            else
            {
                Console.WriteLine("Este item não está disponível.");
            }
        }

        public void DevolverItem(IPodeSerEmprestado item)
        {
            item.Devolver();
            emprestimo.Add(item);
        }
    }
}
