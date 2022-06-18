using System;

namespace RetanguloProject
{
    public class Retangulo
    {
        public double b, a, area;

        public void ExibirPrioridades()
        {
            area = b * a;

            Console.WriteLine("A base do retânguo é " +b);
            Console.WriteLine("A altura do retânguo é " +a);
            Console.WriteLine("Area do retângulo é " +b+ " x " +a);
            Console.WriteLine("Resultado da area: "+area);

        }
    }


}    