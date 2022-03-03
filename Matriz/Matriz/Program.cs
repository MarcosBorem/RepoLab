using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');//Comando split

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);

                }

            }
            Console.Write("MAIN DIAGONAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + (" "));
            }
            Console.WriteLine();
            int contador = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contador++;
                    }

                }
            }
            Console.WriteLine("NEGATIVE NUMBERS: " + contador);
        }
    }
}
