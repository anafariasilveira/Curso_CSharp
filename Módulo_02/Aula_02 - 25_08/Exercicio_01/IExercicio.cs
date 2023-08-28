using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_25_08
{
    public interface IExercicio
    {
        void FazerProva()
        {
            Console.WriteLine("Fazendo a prova.");
        }
        void FazerTreino()
        {
            Console.WriteLine("Estou treinando");
        }
        void FazerFortalecimento();
        void FazerAlongamento();
    }
}
