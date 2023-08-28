using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_LMS
{
    /*
     * public abstract class AnimalBase
{   
	public abstract void comer(string comida);    	
	public abstract void dormir();
	public abstract string emitirSom();
}
    */
    public interface IAnimal
    {
        void Comer(string comida);
        void Dormir();
        string EmitirSom();
    }
}
