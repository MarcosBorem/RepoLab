using System;

namespace ExercicioFixacaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro[] vect = new Cadastro[10];

            Console.WriteLine("Quantos quartos você quer alugar? ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Alguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Cadastro(nome, email);


            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {

                    Console.WriteLine("Quartos ocupados:");
                    Console.WriteLine(i + ": " + vect[i]);
                }


            }
          
        }
    }
}
