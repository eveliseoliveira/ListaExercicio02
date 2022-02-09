using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC\n");

            double peso, altura, imc = 0;

            Console.WriteLine("Infome seu peso: ");

            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");

            altura = double.Parse(Console.ReadLine());

            imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
                Console.WriteLine("\nVocê está abaixo do peso");
            
            else if (imc > 18.5 && imc <= 25)
                Console.WriteLine("\nSeu peso é normal");
            
            else if (imc > 25 && imc <= 30)
                Console.WriteLine("\nVocê está acima do peso");
            
            else if (imc > 30)
                Console.WriteLine("\nVocê está obeso");

            Console.ReadLine();
        }
    }
}
