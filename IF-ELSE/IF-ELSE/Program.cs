using System;

namespace IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A HORA INICIAL DO JOGO: ");
            int horainicial = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A HORA FINAL DO JOGO: ");
            int horafinal = int.Parse(Console.ReadLine());

            int duracaohoras;
            if (horainicial < horafinal)
            {
                duracaohoras = horafinal - horainicial;
            }
            else
            {
                duracaohoras = 24 - horainicial + horafinal;
            }
            Console.WriteLine(" O JOGO DUROU " + duracaohoras + " HORA(S) ");
        }

    }
}
