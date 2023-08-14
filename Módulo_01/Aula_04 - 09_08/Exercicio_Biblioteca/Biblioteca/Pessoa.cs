using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pessoa 
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Turma { get; set; }
        public int Matricula { get; set; }

        public Pessoa(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}
