using System;
using System.Globalization;
namespace SEGUNDOPROBLEMAEXEMPLOCLASSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("QUANTIDADE NO ESTOQUE: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: "+p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos adicionados em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);
            Console.WriteLine("Dados atualizados: "+p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);
            Console.WriteLine("Dados atualizados: "+p);
        }
    }
}
