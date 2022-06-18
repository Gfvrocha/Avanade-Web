namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.calculadora();
        }

        static void calculadora()
        {
            Console.WriteLine("Escolha a operação desejada entre 1 a 4.");
            Console.WriteLine("1) - Adição (+)");
            Console.WriteLine("2) - Subtração (-)");
            Console.WriteLine("3) - Multiplicação (x)");
            Console.WriteLine("4) - Divisão (/)");

            int operation = int.Parse((Console.ReadLine()));

            Console.WriteLine("Você escolheu a operação " + operation);

            Console.WriteLine("Escolha o priemiro número");
            int n1 = int.Parse((Console.ReadLine()));

            Console.WriteLine("Escolha o segundo número");
            int n2 = int.Parse((Console.ReadLine()));

            if(operation == 1)
            {
                Console.WriteLine("A soma entre " +n1+ " + " +n2+ " é = " +(n1+n2));
            }else if(operation == 2)
            {
                Console.WriteLine("A subtração entre " +n1+ " - " +n2+ " é = " +(n1-n2));
            }else if(operation == 3)
            {
                Console.WriteLine("A multiplicação entre " +n1+ " x " +n2+ " é = " +(n1*n2));
            }else if(operation == 4)
            {
                Console.WriteLine("A divisão entre " +n1+ " e " +n2+ " é = " +(n1/n2));
            }

            
        }
    }

}        
