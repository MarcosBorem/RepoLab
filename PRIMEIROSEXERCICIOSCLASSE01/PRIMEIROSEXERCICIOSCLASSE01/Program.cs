using System;

namespace PRIMEIROSEXERCICIOSCLASSE01
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Pessoa primeirapessoa = new Pessoa();
            Pessoa segundapessoa = new Pessoa();

            Console.WriteLine("DADOS DA PRIMEIRA PESSOA: ");
            Console.Write("NOME: ");
            primeirapessoa.nome = Console.ReadLine();
            Console.Write("IDADE: ");
            primeirapessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("DADOS DA SEGUNDA PESSOA: ");
            Console.Write("NOME: ");
            segundapessoa.nome = Console.ReadLine();
            Console.Write("IDADE: ");
            segundapessoa.idade = int.Parse(Console.ReadLine());

            if (segundapessoa.idade > primeirapessoa.idade)
            {
                Console.WriteLine("PESSOA MAIS VELHA: "+segundapessoa.nome);
            }
            else
            {
                Console.WriteLine("PESSOA MAIS VELHA: "+primeirapessoa.nome);
            }
        }
    }
}
