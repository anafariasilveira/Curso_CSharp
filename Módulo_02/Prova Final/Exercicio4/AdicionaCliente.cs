using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class AdicionaCliente : IArmazenamentoCliente
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (cliente.CPF.Length != 11)
                return "Cliente com CPF inválido";


            string connectionString = "MinhaConnectionString";
            string commandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF) VALUES (@nome, @email, @cpf))";

            var parameters = new Dictionary<string, string>();
            parameters.Add("nome", cliente.Nome);
            parameters.Add("email", cliente.Email);
            parameters.Add("cpf", cliente.CPF);

            //Abrindo conexão e gravar na base...

            var mail = "empresa@empresa.com";
            var assunto = "Bem Vindo.";
            var corpo = "Parabéns! Você está cadastrado.";

            //Enviando email...

            return "Cliente cadastrado com sucesso!";
        }

    }
}
