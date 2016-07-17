namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BorderControl
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IUnit> units = new List<IUnit>();
            while (input != "End")
            {
                string[] tokens = input.Split();
                if (tokens.Length == 3)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    units.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(tokens[0], tokens[1]);
                    units.Add(robot);
                }

                input = Console.ReadLine();
            }

            string invalidId = Console.ReadLine();

            List<IUnit> illegal = units.Where(u => u.Id.EndsWith(invalidId)).ToList();

            illegal.ForEach(u => Console.WriteLine(u.Id));
        }
    }
}
