using System;

namespace Zoologico_1
{
    public class Veterinario
    {
        public void Examinar(Animal animal)
        {
            Console.WriteLine("Examinando o animal: "); //animal.Nome
            animal.EmitirSom();
            Console.WriteLine("Exame finalizado do animal:");
        }

        public void Examinar(List<Animal> animais)
        {            
                foreach (Animal animal in animais)
                {
                    Examinar(animal);
                }
            


        }
    }
}

