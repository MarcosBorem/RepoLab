using System;

namespace ExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do raio do círculo: ");
            double raiocirculo = double.Parse(Console.ReadLine());

            double pi = 3.14159;

            double formula = pi * (Math.Pow(raiocirculo, 2));

            Console.WriteLine("O valor da área é: " + formula.ToString("F4"));
        }
    }
}
