using System;
using ExericicioFixacaoSecao09.Entities;
using ExericicioFixacaoSecao09.Entities.Enuns;

namespace ExericicioFixacaoSecao09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Cliente data: ");

            Console.Write("Name: ");
            string clientename = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY)");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Order Date: ");

            Console.Write("Status");
            //SE ATENTAR A ISSO
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            // NÃO ESQUECER DISSO TBM
            Client client = new Client(clientename, email, birthdate);

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$ Enter #{i} item date: ");
            }

        }
    }
}
