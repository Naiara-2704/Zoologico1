using System;

namespace Zoologico_1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Preguica tom = new Preguica();
            tom.Nome = "Tom";
            tom.EmitirSom();
            Zoollogicoo Zoo = new Zoollogicoo();
            Veterinario Vet = new Veterinario();
            Zoo.animais.Add(tom);


            Elefante dumbo = new Elefante();
            dumbo.Nome = "Dumbo";
            dumbo.EmitirSom();
            Zoo.animais.Add(dumbo);
            Vet.Examinar(Zoo.animais);


        }
    }
}