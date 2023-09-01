namespace Exercicio01_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varejo empresaVarejo = new("Florin Ajardinamento LTDA", "00.931.496/0001-17", "Fenix Floricultura", "Rua Manoel Ribas, 1409 - Neva - Cascavel - PR", "(045) 3035-4580");
           
            empresaVarejo.ImprimirInformacoesEmpresa();
            Console.WriteLine();
            empresaVarejo.RealizarVenda();
            Console.WriteLine();

            Empreiteira empresaEmpreiteira = new("Cascavel Parana Construções LTDA", "00.444.491/0001-60", "Paraná Construções", "Avenida Brasil, 1158 - FAG - Cascavel - PR", "(045) 33264004");

            empresaEmpreiteira.ImprimirInformacoesEmpresa();
            Console.WriteLine();
            empresaEmpreiteira.RealizarVenda();
        }
    }
}