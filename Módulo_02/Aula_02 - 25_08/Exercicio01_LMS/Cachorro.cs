using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_LMS
{
    /*
     * public class Cachorro : AnimalBase
{
	public string nome { get; set; }    	
	public string raca { get; set; }    	

	public override void comer(string comida){}
	public override void dormir(){}
	public override string emitirSom() { return "AuAu"; }
}
    */

    internal class Cachorro : IAnimal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
 

        public void Comer(string comida)
        {
            Console.WriteLine($"O cachorro está comendo {comida}.");
        }
        public void Dormir()
        {
            Console.WriteLine("O cahcorro dorme durante a noite.");
        }
        public string EmitirSom()
        {
            return "AuAu";
        }
    }
}
