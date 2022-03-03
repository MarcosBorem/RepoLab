using System;
using System.Globalization;
namespace EXERCICIOFIXACAOMEMBROSESTATICOS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual é a cotação do dolar? ");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares você vai comprar? ");
            double Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Resultado = ConversorDeMoeda.ValorReais(Cotacao, Dolares);

            Console.WriteLine("Valor a ser pago em reais: "+Resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
