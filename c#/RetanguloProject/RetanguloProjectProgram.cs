using System;

namespace RetanguloProject
{
    class Program
    {
        static void Main(string[] args)

        {
            Program.RetanguloValores();
        }

        static void RetanguloValores()
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Qual a medida da base do retângulo?");
            retangulo.b = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a medida da altura do retângulo?");
            retangulo.a = double.Parse(Console.ReadLine());

            retangulo.ExibirPrioridades();



        }

    }

}    