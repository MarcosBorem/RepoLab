using System;
using System.Collections.Generic;
namespace ExercicioFixacaoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            List <Funcionario> cadastro = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine());
                cadastro.Add(new Funcionario(id, nome, salario));
                  }
            
            Console.Write("Entre com o ID do funcionário que terá aumento de salário: ");
            int id2 = int.Parse(Console.ReadLine());

            Funcionario fun = cadastro.Find(x => x.Id == id2);//Primeira ocorrência que id == id2

            if (fun == null)
            {
                Console.WriteLine("Id não existente");
            }
            else
            {
                Console.Write("Entre com a porcentagem: ");
                int porcentagem = int.Parse(Console.ReadLine());
                fun.IncrementoSalario(porcentagem);
                
            }
            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizados");
            foreach (Funcionario obj in cadastro)
            {
                Console.WriteLine(obj);

            }




                /*List<string> nomes = new List<string>();

                nomes.Add("Marcos");
                nomes.Add("Matheus");
                nomes.Add("Zelaine");
                nomes.Add("Marco Aurélio");


                nomes.Insert(4, "Zelaine");// iserir na posição 4 o nome Zelaine
                foreach (string obj in nomes)
                {
                    Console.WriteLine(obj);
                }

                Console.WriteLine(nomes.Count); //contador de posições

                string s1 = nomes.Find(x => x[0] == 'M'); // Primeira ocorrência com a letra M
                Console.WriteLine(s1);

                string s2 = nomes.FindLast(x => x[0] == 'M'); //ultima ocorrência de quem começa quem M
                Console.WriteLine(s2);
                */
            }



    }
}
