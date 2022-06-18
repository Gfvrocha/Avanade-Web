using System;

namespace AnimalsProject
{
    public class Animal1
    {
        public string especie;

        public string reino;

        public virtual void Comer()
        {
            Console.WriteLine("Animal comendo");
        }

        public virtual void Respirar()
        {
            Console.WriteLine("Animal respirando");
        }

    }
    

}