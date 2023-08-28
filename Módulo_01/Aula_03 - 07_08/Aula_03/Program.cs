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

            WriteLine("Bem vindo!");
            WriteLine();

            WriteLine("Informe o nome do produto:");
            produto.Nome = ReadLine();

            WriteLine("Informe o preço do produto:");
            Write("R$ "); produto.Preco = double.Parse(ReadLine());
          
            WriteLine("Informe a quantidade do produto em estoque:");
            produto.Estoque = int.Parse(ReadLine());
            WriteLine();

            produto.resumo();
            WriteLine();

            WriteLine("O que deseja fazer? \n 1- Adicionar produtos ao estoque. \n 2- Remover produtos do estoque. \n 3- Ver resumo. \n 4- Sair.");
            string controle = ReadLine();

            bool opcao = true;

                switch (controle)
                {
                    case "1":

                        WriteLine("Deseja adicionar quantos produtos?");
                        produto.adicionaestoque(int.Parse(ReadLine()));
                    break;

                    case "2":

                        WriteLine("Deseja remover quantos produtos?");
                        produto.removeestoque(int.Parse(ReadLine()));
                    break;

                    case "3":

                        produto.resumo();
                    break;

                    case "4":
                        opcao = false;
                    break;

                    default:
                        WriteLine("Selecione uma opção válida. \n");
                    break;

                } 
            ReadKey();                    
        }
    }
}
