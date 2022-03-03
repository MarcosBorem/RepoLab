using System;
using System.Globalization;
namespace EXERCICIOSFOR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME O NÚMERO DE TESTES: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}