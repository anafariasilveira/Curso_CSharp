using Exercicio02_Aula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula
{
    public class Empreiteira : Empresa, IInformacoes
    {
        public Empreiteira(string nome, string cnpj, string nomefantasia, string endereco, string telefone) : base (nome, cnpj, nomefantasia, endereco, telefone)
        {
            
        }
        public void RealizarVenda()
        {
            Console.WriteLine("Eu presto serviços.\n");
        }
    }
}
