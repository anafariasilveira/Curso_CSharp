using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06_LMS
{
    public class AlgumaClasse
    {
        public int CampoX;
        private int CampoY;
        public int Propriedade1 { get; set; }
        private int Propriedade2 { get; set; }

        public string Metodo1()
        {
            return "Método1 chamado";
        }

        private string Metodo2()
        {
            return "Method2 chamado";
        }

    }
}
