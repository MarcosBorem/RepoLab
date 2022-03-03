using System;
using System.Globalization;
namespace EXERCICIOSFOR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME QUANTOS PARES DE NÚMEROS IRÁ DIGITAR: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] pares = Console.ReadLine().Split(' ');
                double a = double.Parse(pares[0], CultureInfo.InvariantCulture);
                double b = double.Parse(pares[1], CultureInfo.InvariantCulture);
                
                double divisao = a / b;
                                
                if (b == 0)
                {
                    Console.WriteLine("DIVISÃO IMPOSSÍVEL");
                }
                else
                {
                    Console.WriteLine(""+divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}