using System;

namespace hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.escrever();
            //Program.escreverString("blablabal");
            //Program.escreverSoma();
            //Program.soma(1,2);
            //Program.escreverNu();
            //Program.terceiroEx();
            //Program.escreveSoma();
            
            //Program.cadastro();
            
            //Pessoa pessoa = new Pessoa();
            //pessoa.exercicioCadastro();

            //pessoa.casado = true;
            //pessoa.nome = "Felipe Rocha";
            //pessoa.altura = 1.75;
            //pessoa.idade = 32;
            //pessoa.mae = "Cida";
           
            //Capivara capivara = new Capivara();
            //capivara.comer();
            //Program.medidas();
                     
        }

        

        static void escrever()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Seja bem-vindo, Felipe Rocha");
            string nome = "Felipe Rocha";
            int idade = 32;
            double altura = 1.75;
            bool casado = true;
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(casado);

        }

        static void escreverString(string s)
        {
            Console.WriteLine(s);
        }

        static void escreverSoma()
        {
            int n1 = 1;
            int n2 = 2;
            Console.WriteLine("O resultado de " +n1+ " + " +n2+ " é = " +(n1 + n2));
        }

        static void soma(int n1, int n2)
        {
            int result = n1 + n2;

            Console.WriteLine(result);
        }
        
        static void escreverNu()
        {
            Console.WriteLine("Digite o primeiro número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A multiplicação de " +n1+ " x " +n2+ " = " +(n1*n2));

        }
   

        static void escreveSoma()
        {
            Console.WriteLine("Digite o 1º número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da soma de "+a+ " + " +b+ " é = ");
            Program.soma(a,b);
        }
     
    }
        
}

    

