using System;

namespace EXERCICIOSFOR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INFORME QUANTOS NÚMEROS INTEIROS IRÁ DIGITAR: ");
            int n = int.Parse(Console.ReadLine());
            int contadordentro = 0;
            int contadorfora = 0;
            
                for (int i = 0; i < n; i++)
                {
                Console.WriteLine("INFORME OS NÚMEROS UM DE CADA VEZ: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contadordentro = contadordentro + 1;
                }
                else
                {
                    contadorfora = contadorfora + 1;
                }
            }
            Console.WriteLine(contadordentro+ " IN");
            Console.WriteLine(contadorfora+ " OUT");
            

        }
    }
}
