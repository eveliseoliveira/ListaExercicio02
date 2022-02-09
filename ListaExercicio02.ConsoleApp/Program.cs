using System;

namespace ListaExercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor_a, valor_b, valor_c, resultado_operacao = 0;

            Console.WriteLine("Insira o valor de A: ");

            valor_a = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de B: ");

            valor_b = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de C: ");

            valor_c = float.Parse(Console.ReadLine());

            resultado_operacao = valor_a + valor_b;

            if (resultado_operacao < valor_c)
                Console.WriteLine("A soma de A + B é menor que C");
            
            else if (resultado_operacao > valor_c)
                Console.WriteLine("A soma de A + B é maior que C");
            
            Console.ReadLine();
        }
    }
}

