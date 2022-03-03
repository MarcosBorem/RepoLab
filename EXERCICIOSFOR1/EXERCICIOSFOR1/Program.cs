using System;

namespace EXERCICIOSFOR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME UM NÚMERO INTEIRO: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {

                        Console.WriteLine("Os números ímpares são: " + i);

                    }
                }
            }
            else
            {
                Console.WriteLine("VALOR FORA DO INTERVALO!");
            }
        }
    }
}
