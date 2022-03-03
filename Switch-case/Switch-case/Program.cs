using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    Console.WriteLine(day);
                    break;
                case 2:
                    day = "Segunda";
                    Console.WriteLine(day);
                    break;
                case 3:
                    day = "Terça";
                    Console.WriteLine(day);
                    break;
                case 4:
                    day = "Quarta";
                    Console.WriteLine(day);
                    break;
                case 5:
                    day = "Quinta";
                    Console.WriteLine(day);
                    break;
                case 6:
                    day = "Sexta";
                    Console.WriteLine(day);
                    break;
                case 7:
                    day = "Sábado";
                    Console.WriteLine(day);
                    break;
                default:
                    day = "Dia inválido!!!";
                    Console.WriteLine(day);
                        break;
            }
        }
    }
}
