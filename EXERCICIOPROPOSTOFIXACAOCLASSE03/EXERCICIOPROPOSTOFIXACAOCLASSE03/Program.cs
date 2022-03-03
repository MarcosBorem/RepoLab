using System;
using System.Globalization;
namespace EXERCICIOPROPOSTOFIXACAOCLASSE03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno n = new Aluno();
            Console.Write("Nome do Aluno: ");
            n.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            n.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL= "+n.NotaFinal(), CultureInfo.InvariantCulture);

            if (n.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "+n.NotaRestante().ToString("F2"),CultureInfo.InvariantCulture + "pontos");
            }
        }
    }
}
