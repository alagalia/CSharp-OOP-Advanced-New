namespace _05.BorderControl
{
    public class Citizen : IUnit
    {
        private string name;

        private int age;

        private string id;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Id { get; }
    }
}