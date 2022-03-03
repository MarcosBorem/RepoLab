using System;

namespace IFELSE_EXERCICIO5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o codigo do item: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade item: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valor;

            if (codigo == 1)
            {
                valor = quantidade * 4;
                Console.WriteLine("TOTAL: R$" + valor.ToString("F2"));
            }
            else if (codigo == 2)
            {
                valor = quantidade * 4.5;
                Console.WriteLine("TOTAL: R$" + valor.ToString("F2"));
            }
            else if (codigo == 3)
            {
                valor = quantidade * 5;
                Console.WriteLine("TOTAL: R$" + valor.ToString("F2"));
            }

            else if (codigo == 4)
            {
                valor = quantidade * 2;
                Console.WriteLine("TOTAL: R$" + valor.ToString("F2"));
            }
            else
            {
                valor = quantidade * 1.5;
                Console.WriteLine("TOTAL: R$" + valor.ToString("F2"));
            }
        }
    }
}
