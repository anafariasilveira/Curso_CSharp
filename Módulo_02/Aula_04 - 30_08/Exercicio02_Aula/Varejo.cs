using Exercicio02_Aula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula
{
    public class Varejo : Empresa, IInformacoes
    {
        public Varejo(string nome, string cnpj, string nomefantasia, string endereco, string telefone) : base (nome, cnpj, nomefantasia, endereco, telefone)
        {
        }
        public void RealizarVenda()
        {
            Console.WriteLine("Eu vendo produtos.\n");
        }
    }
}
