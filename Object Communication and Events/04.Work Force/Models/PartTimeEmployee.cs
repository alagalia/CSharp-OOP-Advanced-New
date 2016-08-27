namespace _04.Work_Force.Models
{
    using _04.Work_Force.Interfaces;

    public class PartTimeEmployee : IEmployee
    {
        private const int WorkHoursPerWeek = 20;

        public PartTimeEmployee(string name)
        {
            this.Name = name;
            this.Hours = WorkHoursPerWeek;
        }   

        public string Name { get; set; }

        public int Hours { get; set; }
    }
}