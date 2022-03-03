using System;
using System.Globalization;
namespace WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            while (numero >= 0.0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine("A raiz quadrada é " + raiz.ToString("F3"));
                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("NÚMERO NEGATIVO!!!!");
        }

    }
}
