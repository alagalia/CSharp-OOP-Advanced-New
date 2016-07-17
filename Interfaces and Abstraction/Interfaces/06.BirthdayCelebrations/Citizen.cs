namespace _06.BirthdayCelebrations
{
    public class Citizen : IUnit
    {
        public Citizen(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public string Birthdate { get; }
    }

}