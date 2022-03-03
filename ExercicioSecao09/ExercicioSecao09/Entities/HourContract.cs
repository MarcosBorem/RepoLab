using System;


namespace ExercicioSecao09.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; }

        public int Hours { get; set; }

        public HourContract() 
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue ()
        {
            return Hours * ValuePerHour;

        }

    }
}
