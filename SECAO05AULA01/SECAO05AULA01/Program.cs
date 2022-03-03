using System;
using System.Globalization;
namespace SECAO05AULA01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
           

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos adicionados em estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(Quantidade);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            Quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(Quantidade);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
