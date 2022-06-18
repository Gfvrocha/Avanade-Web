using System;

namespace AnimalsProject
{
    public class Capivara: Animal1
    {
        public override void Comer()
        {
            base.Comer();
            Console.WriteLine(this.especie);
            Console.WriteLine("Capivara comendo");
        }
    }
}
    