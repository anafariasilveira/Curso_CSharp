using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula
{
    public class Empreiteira : Empresa
    {
        public Empreiteira(string nome, string cnpj, string nomefantasia, string endereco, string telefone) : base (nome, cnpj, nomefantasia, endereco, telefone)
        {
            
        }
        public override void RealizarVenda()
        {
            Console.WriteLine("Eu presto serviços.");
        }
    }
}
