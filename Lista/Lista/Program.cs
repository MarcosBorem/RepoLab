using System;
using System.Collections.Generic;
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Marcos");
            nomes.Add("Matheus");
            nomes.Add("Zelaine");
            nomes.Add("Marco Aurélio");
            

            nomes.Insert(4,"Zelaine");// iserir na posição 4 o nome Zelaine
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(nomes.Count); //contador de posições
            
            string s1 =  nomes.Find(x => x[0] == 'M'); // Primeira ocorrência com a letra M
            Console.WriteLine(s1);

            string s2 = nomes.FindLast(x => x[0] == 'M'); //ultima ocorrência de quem começa quem M
            Console.WriteLine(s2);
        }
        
        
    }
}
