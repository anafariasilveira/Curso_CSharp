using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public abstract class Funcionario
    {
        private string Nome { get; set; }
        private string Matricula { get; set; }
        public double SalarioBase { get; protected set; }

        public Funcionario (string nome, string matricula, double salariobase)
        {
            Nome = nome;
            Matricula = matricula;
            SalarioBase = salariobase;
        }
        public abstract double calculaSalario();
    }
}
