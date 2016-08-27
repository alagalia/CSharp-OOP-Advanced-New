using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.King_s_Gambit_Extended
{
    using _02.King_s_Gambit.Interfaces;
    using _02.King_s_Gambit.Models;

    using _05.King_s_Gambit_Extended.Models;
    using _05.King_s_Gambit_Extended.Repositories;

    public class StartUp
    {
        public static void Main()
        {
            UnitsRepository army = new UnitsRepository();

            var kingName = Console.ReadLine();
            var king = new King(kingName);
            
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

        private static void AddToKingsArmy(King king, string input, UnitsRepository army, string type)
        {
            string[] names = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (type)
            {
                case "RoyalGuards":
                    foreach (var royalGuardName in names)
                    {
                        army.AddToArmy(new RoyalGuard(royalGuardName, king));
                    }
                    break;
                case "Footmen":
                    foreach (var footManName in names)
                    {
                        army.AddToArmy(new Footman(footManName, king));
                    }
                    break;
            }
        }
    }
}
