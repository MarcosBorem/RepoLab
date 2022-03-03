using System;
using System.Globalization;
using REFAZENDOEXERCICIO01SECAO09.Entities;
using REFAZENDOEXERCICIO01SECAO09.Entities.Enuns;
namespace REFAZENDOEXERCICIO01SECAO09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name? ");
            string DepartmentName = Console.ReadLine();

            Console.Write("Enter worker data: ");
           

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            // RECEBE O ENUM.PARSE PARAMETRIZADO COM O WORKER LEVEL
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //INSTANCIAR O DEPARTAMENTO
            Department dept = new Department(DepartmentName);
            // INSTANCIAR O OBJETO WORKER

            Worker worker = new Worker(name, level, baseSalary, dept);
        }
    }
}
