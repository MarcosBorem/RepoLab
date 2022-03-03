using System;
using System.Collections.Generic;
using System.Text;
using REFAZENDOEXERCICIO01SECAO09.Entities.Enuns;



namespace REFAZENDOEXERCICIO01SECAO09.Entities
{
    class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        //COMPOSIÇÃO
        public Department Department { get; set; }
                                                               //Instanciando a lista para q não seja nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();    

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        //MÉTODO 
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract) 
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;

            //percorrer a lista de contratos
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
