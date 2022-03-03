using System;
using System.Globalization;
namespace EXERCICIOSFOR7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME UM NÚMERO: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double primeiro = i;
                double segundo = (Math.Pow(i,2));
                double terceiro = (Math.Pow(i, 3));

                Console.WriteLine( $"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}
