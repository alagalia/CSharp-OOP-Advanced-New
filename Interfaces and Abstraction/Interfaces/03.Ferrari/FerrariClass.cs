namespace _03.Ferrari
{
    using System;
    class FerrariClass
    {   
        static void Main()
        {
            string driver = Console.ReadLine();
            Ferrari f = new Ferrari(driver);
            Console.WriteLine($"{Ferrari.Model}/{f.Brakes()}/{f.Gas()}/{f.Name}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }

    public interface ICar
    {
        string Brakes();

        string Gas();
    }

    public class Ferrari : ICar
    {
        public const string Model = "488-Spider";
        private string name;

        public Ferrari(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }
    }
}
