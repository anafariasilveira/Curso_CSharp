using Exercicio_Aula08.Interfaces;

namespace Exercicio_Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animais = new List<IAnimal>();

            ICachorro cachorro = new Cachorro();
            animais.Add(cachorro);

            IGato gato = new Gato();
            animais.Add(gato);

            IPassaro passaro = new Passaro();
            animais.Add(passaro);

            foreach (var animal in animais)
            {
                animal.Comer();
                animal.Reproduzir();

                if (animal is IGato gato1)
                    gato1.Miar();

                if (animal is ICachorro cachorro1)
                    cachorro1.Latir();

                if (animal is IPassaro passaro1)
                    passaro1.Voar();

                if (animal is IAnimalDomestico animalDomestico)
                    animalDomestico.Obedecer();

            }
        }
    }
}