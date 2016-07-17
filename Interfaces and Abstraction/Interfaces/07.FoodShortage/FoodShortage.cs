using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodShortage
{
   public class FoodShortage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<IUnit> units = new List<IUnit>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 4)
                {
                    Citizen citizen = new Citizen(tokens[0]);
                    units.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(tokens[0]);
                    units.Add(rebel);
                }
            }

            string name = Console.ReadLine();
            while (name != "End")
            {
                IUnit found = units.FirstOrDefault(u => u.Name==name);
                found?.BuyFood();

                name = Console.ReadLine();
            }

            int totalFood = units.Sum(unit => unit.Food);
            Console.WriteLine(totalFood);
        }
    }

    public interface IBuyer
    {
        void BuyFood();
    }

    public interface IUnit : IBuyer
    {
        string Name { get; }

        int Food { get; set; }
    }

    public class Citizen : IUnit
    {
        private int food;
        public Citizen(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int Food
        {
            get
            {
                return this.food;
            }
            set
            {
                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }

    public class Rebel : IUnit
    {
        private int food;

        public Rebel(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int Food
        {
            get
            {
                return this.food;
            }
            set
            {
                this.food = value;
            }
        }
       
        public void BuyFood()
        {
            this.food += 5;
        }
    }
}
