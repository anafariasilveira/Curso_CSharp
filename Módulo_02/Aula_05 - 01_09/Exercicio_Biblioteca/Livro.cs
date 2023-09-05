using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool Emprestimo { get; set; }
        public DateTime DataDeEmprestimo { get; set; } = new();
        public DateTime DataDeDevolucao { get; set; } = new();

        public Livro(string titulo, string autor, int anopubli, int numeropags) : base (titulo, autor, anopubli, numeropags)
        {
            Emprestimo = true;
            
        }
        public string Emprestar()
        {
            if (!Emprestimo)
            {
                Emprestimo = true;

                StringBuilder sb = new();
                sb.AppendLine($"Livro emprestado com sucesso!");
                sb.AppendLine();
                sb.AppendLine($"Data do emprestimo: {DataDeEmprestimo}.");
                sb.AppendLine($"Título do livro: {Titulo}.");
                sb.AppendLine($"Autor: {Autor}.");
                sb.AppendLine($"Ano de publicação: {AnoPubli}.");
                sb.AppendLine($"Quantidade de páginas: {NumeroPags}.");  

                return sb.ToString();
            }else
            {
                return $"O livro {Titulo} não está disponível para empréstimo."; 
            }
        }
        public string Devolver(DateTime datadevolucao)
        {
            DataDeDevolucao = DataDeEmprestimo.AddDays(14);

            if (datadevolucao <= DataDeDevolucao)
            {
                return "Devolução feita com sucesso!";
            }
            else
            {
                return "Procure a secretaria.";
            }
        }
    }
}
