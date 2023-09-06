using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public DateTime DataDeEmprestimo { get; set; } = new();
        public DateTime DataDeDevolucao { get; set; } = new();

        public MidiaDigital(string titulo, string autor, int anopubli, int numeropags) : base(titulo, autor, anopubli, numeropags)
        {
           
        }
        public string Emprestar()
        {
                DataDeEmprestimo = DateTime.Now;

                StringBuilder sb = new();

                sb.AppendLine($"Midia Digital emprestada com sucesso!");
                sb.AppendLine();
                sb.AppendLine($"Data do emprestimo: {DataDeEmprestimo}");
                sb.AppendLine($"Título da revista: {Titulo}");
                sb.AppendLine($"Autor: {Autor}");
                sb.AppendLine($"Ano de publicação: {AnoPubli}");

            return sb.ToString();
        }
        public string Devolver()
        {
            return "Midia Digital não necessita ser devolvida."; 
        }
    }
}

