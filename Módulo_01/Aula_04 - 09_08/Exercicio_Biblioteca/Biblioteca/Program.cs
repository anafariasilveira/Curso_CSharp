using System.Globalization;
using System;
using static System.Console;


namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emprestimo emprestimo = new();

            WriteLine("Bem Vindo! \n\nDigite o título do livro desejado e o autor:");
            Livro livro = new(ReadLine(), ReadLine());

            WriteLine("Digite seu nome e sua matrícula:");
            Pessoa pessoa = new (ReadLine(), int.Parse(ReadLine()));

            DateTime dataemprestimo = DateTime.Now;
            

            emprestimo.EmprestimoDoLivro(livro, pessoa, dataemprestimo);

           string resposta = "N";

            WriteLine("Deseja outro livro? S- Sim N- Não");
            resposta = ReadLine();

            ReadKey();
            Clear();

            if (resposta != "N" || resposta != "n")
            {
                Emprestimo emprestimo2 = new();

                WriteLine("Digite o título do livro desejado e o autor:");
                Livro livro2 = new(ReadLine(), ReadLine());

                emprestimo2.EmprestimoDoLivro(livro, pessoa, dataemprestimo);

                if(livro2 == livro)
                {
                    WriteLine("Este livro não está disponivel, por favor, escolha outro.");
                    return;
                }
            }else
            {
                WriteLine("Obrigado!");
            }
            ReadKey();
            Clear();

            WriteLine("Deseja devolver o livro? S- Sim, N- Não.");
            string resposta2 = ReadLine();

            WriteLine("Digite a data da devolução:");
            DateTime datadevolucao = DateTime.Parse(ReadLine());

            if (resposta2 != "N" || resposta2 != "n")
            {
                emprestimo.Devolucao(livro, pessoa, datadevolucao);
            }
            else
            {
                WriteLine("Obrigado!");
            }
            ReadKey();
        }
    }
}