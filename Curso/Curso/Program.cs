using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomecompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quantidadequarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double precoproduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu úlitmo nome, idade e altura (mesma linha dando espaços): ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimonome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou ");
            Console.WriteLine(nomecompleto);
            Console.WriteLine(quantidadequarto);
            Console.WriteLine(precoproduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimonome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
