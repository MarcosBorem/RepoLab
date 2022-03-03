using System;
using System.Globalization;
using ExercicioSecao09.Entities;
using ExercicioSecao09.Entities.Enums;
namespace ExercicioSecao09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("(Junior/Mid Level/ Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // instanciando objetos
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary,dept);

            Console.Write("Quantos contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                // Instanciar contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Entre com o mês e ano para calcular o ganho no formato (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: "+worker.Name);
            Console.WriteLine("Departament: "+worker.Department.Name);
            Console.WriteLine("Income for: "+monthAndYear+"; " +worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
