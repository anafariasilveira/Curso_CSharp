using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula
{
    public class Chocolate
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }

        public Chocolate(string marca, string tipo, string nome)
        {
            Marca = marca;
            Tipo = tipo;
            Nome = nome;
        }

        public void ImprimeReflection(object objeto)
        {
            PropertyInfo[] propriedade = objeto.GetType().GetProperties();
            Console.WriteLine($"O tipo {objeto.GetType().Name} tem {propriedade.Length} propriedades.");
            Console.WriteLine();

            foreach (var propriedades in propriedade)
            {
                Console.WriteLine($"Tenho a propriedade {propriedades.Name} do tipo {propriedades.PropertyType.Name} e seu valor é {propriedades.GetValue(objeto)}");
            }
        }
    }
}
