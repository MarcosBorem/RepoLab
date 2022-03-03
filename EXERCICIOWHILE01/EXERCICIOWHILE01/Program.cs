using System;
using System.Globalization;
namespace EXERCICIOWHILE01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UMA SENHA: ");
            int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("SENHA INVÁLIDA!!!");
                Console.Write("DIGITE UMA NOVA SENHA: ");
                senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("ACESSO PERMITIDO!");
        }
    }
}
