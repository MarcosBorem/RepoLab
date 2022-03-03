using System;
using System.Globalization;
namespace EXERCICIOFIXACAOSECAO05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inical: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, nome, deposito);//Instanciamento do construtor com 3 argumentos
                
            }
            else
            {
                c = new ContaBancaria(numero, nome); //Instanciamento do construtor com 2 argumentos
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);
            Console.Write("Entre um valor para depósito: ");
            double Deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            c.ValorDeposito(Deposito);
            Console.WriteLine("Dados da conta atualizados: "+c);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.ValorSaque(Saque);
            Console.WriteLine("Dados Atualizados: "+c);

        }
        
    }
    
}
