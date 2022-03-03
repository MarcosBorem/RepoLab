using System;

namespace ESTRUTURAFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("QUANTOS NÚMEROS INTEIROS VOCÊ VAI DIGITAR?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor {0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }
            Console.WriteLine("A SOMA É: " + soma);
        }


    }
}
