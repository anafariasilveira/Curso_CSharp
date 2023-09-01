using Exercicio01_Aula;
using System.Collections.Generic;

namespace Exercicio02_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IInformacoes> informacoes = new();

            IInformacoes empresaVarejo = new Varejo("Florin Ajardinamento LTDA", "00.931.496/0001-17", "Fenix Floricultura", "Rua Manoel Ribas, 1409 - Neva - Cascavel - PR", "(045) 3035-4580");

            IInformacoes empresaEmpreiteira = new Empreiteira("Cascavel Parana Construções LTDA", "00.444.491/0001-60", "Paraná Construções", "Avenida Brasil, 1158 - FAG - Cascavel - PR", "(045) 33264004");

            informacoes.Add(empresaVarejo);
            informacoes.Add(empresaEmpreiteira);

            foreach (var infoatual in informacoes)
            {
                infoatual.ImprimirInformacoesEmpresa((Empresa)infoatual);
                infoatual.RealizarVenda();
            }
        }
    }
}