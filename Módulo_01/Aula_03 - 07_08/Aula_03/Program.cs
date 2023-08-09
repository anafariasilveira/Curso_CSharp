using static Aula_03.Program;
using static System.Console;
using System.Globalization;

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
                WriteLine($"O produto é {Nome}. \n Preço: R$ {Preco}. \n Quantidade em estoque {Estoque}. \n Valor total no estoque: R$ {(Preco * Estoque):N2}");
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
