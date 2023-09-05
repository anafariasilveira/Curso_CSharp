using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Biblioteca
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int AnoPubli { get; set; }
        public int NumeroPags { get; set; }
        //public List<string> Livros { get; set; } = new();
        //public List<string> Revistas { get; set; } = new();

        public ItemBiblioteca(string titulo, string autor, int anopubli, int numeropags)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPubli = anopubli;
            NumeroPags = numeropags;
        }
    }
}
