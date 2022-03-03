using System;
using System.Globalization;
namespace EXERCICIOPROPOSTOFIXACAOCLASSE02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ",CultureInfo.InvariantCulture);
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " +f);

        }
    }
}
