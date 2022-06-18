using System;

namespace AnimalsProject
{
    class Animal
    {
        static void Main(string[] args)
        {
            Animal.AnimalsScore();
        }
         static string AnimalsScore()
        {

            int contCachorro = 0;
            int contGato = 0;
            int contPeixe = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite nome de um animal");
            string animal = Console.ReadLine().ToLower();
            if(animal == "cachorro")
            {
                Cachorro cachorro = new Cachorro();
                cachorro.especie = "raça";
                cachorro.reino = "animal";
                cachorro.Respirar();
                contCachorro++;
                
            }
            else if(animal == "gato")
            {
                Gato gato = new Gato();
                gato.especie = "raça";
                gato.reino = "animal";
                gato.Respirar();
                contGato++;

            } else
            {
                Peixe peixe = new Peixe();
                peixe.especie = "raça";
                peixe.reino = "animal";
                peixe.Respirar();
                contPeixe++;
            }

            }

            return "Foram " + contCachorro + " cachorros " + contGato + " gatos " + contPeixe + " peixes";
        }
    }

   
}   