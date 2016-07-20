namespace _08.MilitaryElite
{
    using System;
    using System.Collections.Generic;

    using _08.MilitaryElite.Factory;
    using _08.MilitaryElite.Interfaces;

    public class MilitaryElite
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<ISoldier> army = new List<ISoldier>();

            while (input != "End")
            {
                try
                {
                    army.Add(SoldierFactory.ProduceSoldier(input));
                }
                catch (Exception)
                {
                    
                }
                input = Console.ReadLine();
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }
        
    }
}
