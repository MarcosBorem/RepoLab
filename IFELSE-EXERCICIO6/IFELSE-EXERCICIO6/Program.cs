using System;

namespace IFELSE_EXERCICIO6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME UM VALOR QUALQUER: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <=25)
            {
                Console.WriteLine("INTERVALO [0,25]");
            }

            else if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("INTERVALO [25,50]");
            }

            else if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("INTERVALO [50,75]");
            }

            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("INTERVALO [75,100]");
            }

            else
            {
                Console.WriteLine("FORA DO INTERVALO!");
            }

        }
    }
}
