namespace _04.Work_Force.Models
{
    using Interfaces;

    public class StandartEmployee : IEmployee
    {
        private const int WorkHoursPerWeek = 40;

        public StandartEmployee(string name)
        {
            this.Name = name;
            this.Hours = WorkHoursPerWeek;  
        }

        public string Name { get; set; }

        public int Hours { get; set; }
    }
}