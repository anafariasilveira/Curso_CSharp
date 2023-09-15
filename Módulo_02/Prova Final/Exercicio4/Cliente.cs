using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public Cliente(int clienteID, string nome, string email, string cpf)
        {
            ClienteId = clienteID;
            Nome = nome;
            Email = email;
            CPF = cpf;
        }
    }
}
