using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula
{
    internal class Sessao
    {
        private Filme Filme { get; set; }
        private Sala Sala { get; set; }
        private DateTime DataHora { get; set; }

        public Sessao(Sala sala, DateTime dataHora)
        {
            Sala = sala;
            DataHora = dataHora;
        }
        public void NomeFilme(Filme filme)
        {
            Filme = filme;
        }
        public override string ToString()
        {
            StringBuilder builder = new();
            builder.AppendLine($"Nome do Filme: {Filme.Titulo}.\n" +
                $"Hora: {DataHora.ToString("dd/MM/yyyy - HH:mm:ss")}\n" +
                $"Sala: {Sala.Numero}");

            return builder.ToString();
        }
    }
}
