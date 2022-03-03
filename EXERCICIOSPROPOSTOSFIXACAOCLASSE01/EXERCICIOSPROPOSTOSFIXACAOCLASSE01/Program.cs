using System;

namespace EXERCICIOSPROPOSTOSFIXACAOCLASSE01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            
            Console.WriteLine("Informe a largura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(r);



        }
    }
}
