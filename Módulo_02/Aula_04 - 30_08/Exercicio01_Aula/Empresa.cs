using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula
{
    public abstract class Empresa
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Empresa(string nome, string cnpj, string nomefantasia, string endereco, string telefone)
        {
            Nome = nome;
            CNPJ = cnpj;
            NomeFantasia = nomefantasia;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ImprimirInformacoesEmpresa()
        {
            Console.WriteLine($"Nome da empresa: {Nome}\n" +
                $"CNPJ: {CNPJ}\n" +
                $"Nome Fantasia: {NomeFantasia}\n" +
                $"Endereço: {Endereco}\n" +
                $"Telefone: {Telefone}");
        }
        public abstract void RealizarVenda();
        
    }
}
