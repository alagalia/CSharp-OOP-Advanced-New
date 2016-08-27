using System;
using _11.CreateCustomClassAttribute.Contracts;
using _11.CreateCustomClassAttribute.Factory.WeaponsFactory;
using _11.CreateCustomClassAttribute.Models.Weapons;
using _11.CreateCustomClassAttribute.Repository;

namespace _11.CreateCustomClassAttribute.IO
{
    public class InputReader
    {
        private readonly WeaponRepository repo;
        private readonly CommandInterpreter interpreter;

        public InputReader(WeaponRepository repo, CommandInterpreter interpreter)
        {
            this.repo = repo;
            this.interpreter = interpreter;
        }



        public void ReadInput()
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                var inputArgs = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                switch (inputArgs[0])
                {
                    case "Create":
                        {
                            var weaponArgs = inputArgs[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            LevelOfRarity weaponRarity = (LevelOfRarity)Enum.Parse(typeof(LevelOfRarity), weaponArgs[0]);

                            WeaponFactory factory = new WeaponFactory(inputArgs[2], weaponRarity);
                            interpreter.InterpretCommandCreate(weaponArgs[1]);
                        }
                        break;
                    case "Add":
                        {
                            var gemArgs = inputArgs[3]
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            var gemClarity = (GemClarities)Enum.Parse(typeof(GemClarities), gemArgs[0]);
                            var gemType = (GemTypes)Enum.Parse(typeof(GemTypes), gemArgs[1]);

                            interpreter.InterpretCommandAdd(inputArgs[1], int.Parse(inputArgs[2]),gemType, gemClarity);
                        }
                        break;
                    case "Remove":
                        this.interpreter.WeaponName = inputArgs[1];
                        this.interpreter.GemIndex = int.Parse(inputArgs[2]);
                        break;
                    case "Print":
                        this.interpreter.WeaponName = inputArgs[1];
                        break;
                }

                this.interpreter.InterpretCommand(inputArgs[0]);
                line = Console.ReadLine();
            }
        }
    }
}