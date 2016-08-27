using _11.CreateCustomClassAttribute.Factory;
using _11.CreateCustomClassAttribute.Factory.GemsFactory;
using _11.CreateCustomClassAttribute.Factory.WeaponsFactory;
using _11.CreateCustomClassAttribute.Models.Gems;
using _11.CreateCustomClassAttribute.Models.Weapons;
using _11.CreateCustomClassAttribute.Repository;

namespace _11.CreateCustomClassAttribute.IO
{
    public class CommandInterpreter
    {
        private WeaponRepository repository;
        private GemFactory gemFactory;
        private WeaponFactory weaponFactory;

        public CommandInterpreter(WeaponRepository repository, GemFactory gemFactory , WeaponFactory weaponFactory )
        {
            this.repository = repository;
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
        }

        public void InterpretCommandCreate(string typeOfWeapon)
        {
            Weapon weapon = null;
            switch (typeOfWeapon)
            {
                case "Axe":
                    weapon = this.weaponFactory.CreateAxe();break;
                case "Knife":
                    weapon = this.weaponFactory.CreateKnife(); break;
                case "Sword":
                    weapon = this.weaponFactory.CreateSword(); break;
            }

            repository.AddToRepository(weapon.Name, weapon);
        }

        public void InterpretCommandAdd(string weaponName, int socket, GemTypes gemType, GemClarities gemClarities)
        {
            Gem gem = null;
            switch (gemType)
            {
                case GemTypes.Ruby:
                    gem = this.gemFactory.ProduceRuby(gemClarities); break;
                case GemTypes.Amethyst:
                    gem = this.gemFactory.ProduceAmethyst(gemClarities); break;
                case GemTypes.Emerald:
                    gem = this.gemFactory.ProduceEmerald(gemClarities); break;
            }
            repository.GetFormRepository(weaponName).AddGem(gem);
        }
    }
}