using Exercicio01_Aula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Aula
{
    public interface IInformacoes
    {
        void ImprimirInformacoesEmpresa(Empresa empresa)
        {
            Console.WriteLine($"Nome da empresa: {empresa.Nome}\n" +
                $"CNPJ: {empresa.CNPJ}\n" +
                $"Nome Fantasia: {empresa.NomeFantasia}\n" +
                $"Endereço: {empresa.Endereco}\n" +
                $"Telefone: {empresa.Telefone}\n");
        }
        void RealizarVenda();
    }
}
