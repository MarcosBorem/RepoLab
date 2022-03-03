using System;
using System.Globalization;
namespace VetoresParte2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            double media = 0.0, precototal = 0.0;
            
            
            for (int i = 0; i < n; i++)
            {
                
                Console.Write("Nome produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                vect[i] = new Produto (nome, preco);
                

                precototal = precototal + preco;
                media = precototal / n;
                
            }
            Console.WriteLine("Preço médio $: "+media.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
