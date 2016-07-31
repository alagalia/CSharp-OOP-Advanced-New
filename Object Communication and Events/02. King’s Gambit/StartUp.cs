namespace _02.King_s_Gambit
{
    using System;
    using System.Collections.Generic;

    using _02.King_s_Gambit.Interfaces;
    using _02.King_s_Gambit.Models;

    public class StartUp
    {
        public static void Main()
        {
            var kingName = Console.ReadLine();
            var king = new King(kingName);

            Dictionary<string, IRemovable> army = new Dictionary<string, IRemovable>();

            var inputData = Console.ReadLine();
            AddToKingsArmy(king, inputData, army, "RoyalGuards");

            inputData = Console.ReadLine();
            AddToKingsArmy(king, inputData, army, "Footmen");

            inputData = Console.ReadLine();
            while (inputData != null && !inputData.Equals("End"))
            {
                CommandDispatcher(inputData, army, king);
                inputData = Console.ReadLine();
            }
        }

        private static void AddToKingsArmy(King king, string input, Dictionary<string, IRemovable> army, string type)
        {
            string[] names = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (type == "RoyalGuards")
            {
                foreach (var royalGuardName in names)
                {
                    army.Add(royalGuardName, new RoyalGuard(royalGuardName, king));
                }
            }
            else if (type == "Footmen")
            {
                foreach (var footManName in names)
                {
                    army.Add(footManName, new Footman(footManName, king));
                }
            }
        }

        private static void CommandDispatcher(string input, Dictionary<string, IRemovable> army, King king)
        {
            string[] tokens = input.Split();
            switch (tokens[0])
            {
                case "Kill":
                    var unit = army[tokens[1]];
                    unit.Kill();
                    army.Remove(tokens[1]);
                    break;
                case "Attack":
                    {
                       king.RespondToAttack();
                        break;
                    }
            }
        }
    }
}
