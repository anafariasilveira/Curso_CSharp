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
        public Livro(string titulo, string autor, int anopubli, int numeropags) : base (titulo, autor, anopubli, numeropags)
        {
            Emprestimo = true;
        }
        public string Emprestar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Livro emprestado com sucesso!");
            sb.AppendLine();
            sb.AppendLine($"Data do emprestimo: {DateTime.Now}");
            sb.AppendLine($"Título do livro: {Titulo}");
            sb.AppendLine($"Autor: {Autor}");
            sb.AppendLine($"Ano de publicação: {AnoPubli}");

            return sb.ToString();

        }
        public string Devolver()
        {
            return $"Devolução feita com sucesso!";
        }
    }
}
