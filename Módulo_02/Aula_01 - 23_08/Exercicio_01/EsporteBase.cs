using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    public abstract class EsporteBase
    {
        public abstract int QuantidadeJogadoresPorTime { get; set; }
        public abstract int TempoDeJogoEmMinutos { get; set; }

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public abstract string ExibirDescricao();
    }
}
