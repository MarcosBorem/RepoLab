using System;
using System.Globalization;
namespace PRIMEIROSEXERCICIOSCLASSE02
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            Funcionarios nome1 = new Funcionarios();
            Funcionarios nome2 = new Funcionarios();
            Console.WriteLine("DADOS DO PRIMEIRO FUNCIONÁRIO: ");
            Console.Write("NOME: ");
            nome1.nome = Console.ReadLine();
            Console.Write("SALÁRIO: ");
            nome1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("DADOS DO SEGUNDO FUNCIONÁRIO: ");
            Console.Write("NOME: ");
            nome2.nome = Console.ReadLine();
            Console.Write("SALÁRIO: ");
            nome2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (nome1.salario + nome2.salario) / 2;
            Console.Write("SALÁRIO MÉDIO: "+media.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
