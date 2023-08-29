using System.ComponentModel;

namespace Exercicio02_LMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Nome = "Açúcar";
            produto.Valor = 4.99;
            produto.setData(produto.DataDeValidade);

            Venda venda = new Venda();

            venda.Produto = produto;
            venda.setData(DateTime.Now);
            Console.WriteLine(TestarVenda.DetalhesVenda(venda));
        }
    }
}