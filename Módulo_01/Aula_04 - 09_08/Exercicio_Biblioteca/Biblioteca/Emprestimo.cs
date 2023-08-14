using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Emprestimo
    {
        private List<Livro> Livros { get; set; } = new();
        private List<Pessoa> Pessoas { get; set; } = new();
        public DateTime DataEmprestimo { get; set; } = new DateTime();
        public DateTime DataDevolucao { get; set; } = new DateTime();
        public Emprestimo()
        {  
        }
        public void EmprestimoDoLivro(Livro livro, Pessoa pessoa, DateTime dataemprestimo)
        {
            DataEmprestimo = dataemprestimo;
            DataDevolucao = DataEmprestimo.AddDays(7);
            Pessoas.Add(pessoa);
            Livros.Add(livro);

            Console.WriteLine($"Livro emprestado com sucesso! \n\n" +
                $"Nome:{pessoa.Nome}\n" +
                $"Matrícula:{pessoa.Matricula}\n" +
                $"Livro: {livro.Titulo}\nAutor: {livro.Autor}\n\n" +
                $"Data do empréstimo: {dataemprestimo}\n" +
                $"Data prevista para devolução:{DataDevolucao}.\n\n");
        }
        public void Devolucao(Livro livro, Pessoa pessoa, DateTime datadevolucao)
        {
            Livros.Remove(livro);
            Pessoas.Remove(pessoa);

            if (datadevolucao >= DataDevolucao)
            {
                Console.WriteLine("Livro atrasado, procure a secretaria.");
            }else
            {
                Console.WriteLine("Obrigado.");
            }
        }
    }
}
