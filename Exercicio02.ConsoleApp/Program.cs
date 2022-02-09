using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor_a, valor_b, valor_c;

            Console.WriteLine("Insira o valor de A: ");

            valor_a = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de B: ");

            valor_b = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de C: ");

            valor_c = float.Parse(Console.ReadLine());

            if(valor_a > valor_b && valor_b > valor_c)
                Console.WriteLine("{0}{1}{2}", valor_a, valor_b, valor_c);

             else if(valor_a > valor_b && valor_b > valor_c && valor_c > valor_b)
                Console.WriteLine("{0}{1}{2}", valor_a, valor_b, valor_c);
             
             else if(valor_b > valor_a && valor_a > valor_c)
                Console.WriteLine("{0}{1}{2}", valor_b, valor_a, valor_c);

             else if (valor_b > valor_a && valor_b > valor_c && valor_c > valor_a)
                Console.WriteLine("{0}{1}{2}", valor_b, valor_c, valor_a);

            else if (valor_c > valor_b && valor_b > valor_a)
                Console.WriteLine("{0}{1}{2}", valor_c, valor_b, valor_a);

            else if (valor_c > valor_b && valor_a > valor_b)
                Console.WriteLine("{0}{1}{2}", valor_c, valor_a, valor_b);

            Console.ReadLine();
        }
    }
}
