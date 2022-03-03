using System;
using System.Globalization;

namespace ExercicioProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do raio do círculo: ");
            double valorraio = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double area = pi * Math.Pow(valorraio, 2);

            Console.WriteLine("O valor da área é: " +area.ToString("F4"));
            

           

        }
    }
}
