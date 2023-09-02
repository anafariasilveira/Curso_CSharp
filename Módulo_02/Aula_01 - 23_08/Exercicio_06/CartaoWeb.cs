using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    public abstract class CartaoWeb
    {
        public string Destinatario { get; }
        public CartaoWeb(string destinatario)
        {
            Destinatario = destinatario;
        }
        public abstract void ShowMessage();

    }
}
