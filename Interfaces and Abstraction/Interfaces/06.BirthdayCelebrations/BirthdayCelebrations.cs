namespace _06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BirthdayCelebrations
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IUnit> units = new List<IUnit>();
            while (input != "End")
            {
                string[] tokens = input.Split();
                if (tokens[0] != "Robot")
                {
                    if (tokens.Length == 5)
                    {
                        Citizen citizen = new Citizen(tokens[1], tokens[4]);
                        units.Add(citizen);
                    }
                    else
                    {
                        Pet pet = new Pet(tokens[1], tokens[2]);
                        units.Add(pet);
                    }
                }

                input = Console.ReadLine();
            }

            string year = Console.ReadLine();

            List<IUnit> illegal = units.Where(u => u.Birthdate.EndsWith(year)).ToList();

            illegal.ForEach(u => Console.WriteLine(u.Birthdate));
        }
    }
}
