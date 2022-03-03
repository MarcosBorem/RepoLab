using System;


namespace REFAZENDOEXERCICIO01SECAO09.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hour { get; set; }

        public HourContract() 
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        //MÉTODO
        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}
