using System;

namespace EXERCICIOSFOR6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME UM NÚMERO");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i ==0)
                {
                    Console.WriteLine("SEUS DIVISORES SÃO: "+i);
                }
            }
        }
    }
}
