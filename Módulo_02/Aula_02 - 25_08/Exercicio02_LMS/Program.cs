using System.ComponentModel;

namespace Exercicio02_LMS
{
    /*
     * Crie a interface IData que fornece os métodos: void  setData(DateTime  data), que ajusta a data do objeto; DateTime  getData(), que retorna a data do objeto; e string  dataString, que retorna a data do objeto como uma string. Crie uma classe Produto que possui nome, valor e data de validade.

       Crie uma classe Venda que possui data e produto. Produto e Venda implementam a interface IData. Crie uma classe estática chamada TestarVenda e um método estático chamado DetalhesVenda que recebe uma Venda e retorna uma string com os dados da venda.

        Exemplo:

        Produto produto = new Produto();
        produto.nome = "Leite Integral";
        produto.valor = 5;
        produto.setData(new DateTime(2023, 3, 1));
        Venda venda = new Venda();
        venda.produto = produto;
        venda.setData(DateTime.Now);
        TestarVenda.DetalhesVenda(venda); //"Data da venda: 29/10/2022 - Produto: Leite Integral - Valor do produto: 5 - Vencimento: 01/03/2023"
        Dica: no método para converter a data para string utilize .ToString("dd/MM/yyyy")
    */
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