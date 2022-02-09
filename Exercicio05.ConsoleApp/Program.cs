using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor_a, valor_b, c = 0;

            Console.WriteLine("Informe o valor de A: ");
            valor_a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            valor_b = int.Parse(Console.ReadLine());

            if(valor_a == valor_b)
                c = valor_a + valor_b;

            if(valor_a != valor_b)
                c = valor_a * valor_b;

                Console.WriteLine("Valor atribuido a váriavel C: " + c);

        Console.ReadLine();
        }
    }
}
