using System;

namespace EXERCICIOWHILE02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME A CORDENADA X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME A CORDENADA Y: ");
            int y = int.Parse(Console.ReadLine());
            while (x != 0 && y != 0)
            {


                if (x > 0 && y > 0)
                {
                    Console.WriteLine("PRIMEIRO");
                    Console.Write("INFORME A CORDENADA X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("INFORME A CORDENADA Y: ");
                    y = int.Parse(Console.ReadLine());
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("SEGUNDO");
                    Console.Write("INFORME A CORDENADA X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("INFORME A CORDENADA Y: ");
                    y = int.Parse(Console.ReadLine());
                }

                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("QUARTO");
                    Console.Write("INFORME A CORDENADA X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("INFORME A CORDENADA Y: ");
                    y = int.Parse(Console.ReadLine());
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("TERCEIRO");
                    Console.Write("INFORME A CORDENADA X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("INFORME A CORDENADA Y: ");
                    y = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");
        }
    }
}
