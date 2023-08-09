/*Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida:• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)• Realizar uma entrada no estoque e mostrar novamente os dados do produto• Realizar uma saída no estoque e mostrar novamente os dados do produto.*/

using static Aula_03.Program;
using static System.Console;

namespace Aula_03
{
    internal class Program
    {
        internal class Produto
        {
            public string Nome;
            public double Preco;
            public int Estoque;
            public void adicionaestoque (int estoque)
            {
                Estoque += estoque;
            }
            public void removeestoque(int estoque)
            {
                Estoque -= estoque;
            }

            public void resumo()
            {
                WriteLine($"O produto é {Nome}. \n Preço: R$ {Preco}. \n Quantidade em estoque {Estoque}. \n Valor total no estoque: R$ {Math.Round(Preco * Estoque):N2}");
            }
        }
        static void Main(string[] args)
        {
            Produto produto = new();

            WriteLine("Informe o nome do produto:");
            produto.Nome = ReadLine();

            WriteLine("Informe o preço do produto:");
            Write("R$ "); produto.Preco = double.Parse(ReadLine());
          
            WriteLine("Informe a quantidade do produto em estoque:");
            produto.Estoque = int.Parse(ReadLine());

            produto.resumo();
            WriteLine();

            WriteLine("Deseja adicionar quantos produtos?");
            produto.adicionaestoque(int.Parse(ReadLine()));

            produto.resumo();
            WriteLine();

            WriteLine("Deseja remover quantos produtos?");
            produto.removeestoque(int.Parse(ReadLine()));

            produto.resumo();
            WriteLine();

            ReadKey();                    
        }
    }
}
