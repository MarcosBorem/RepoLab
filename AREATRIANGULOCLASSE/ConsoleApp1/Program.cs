using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pX, pY, areaY, areaX;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();

            areaY = y.Area();

            Console.WriteLine("O valor da área do triângulo X é: " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("O valor da área do triângulo Y é: " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {
                Console.WriteLine("MAIOR ÁREA: X");
            }
            else
            {
                Console.WriteLine("MAIOR ÁREA: Y");
            }
        }
    }
}
