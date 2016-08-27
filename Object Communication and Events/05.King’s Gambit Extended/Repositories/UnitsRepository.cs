namespace _05.King_s_Gambit_Extended.Repositories
{
    using System.Collections.Generic;

    using _02.King_s_Gambit.Interfaces;

    public class UnitsRepository
    {
        private List<IRemovable> army;

        public UnitsRepository()
        {
            this.army = new List<IRemovable>();
        }

        public void AddToArmy(IRemovable unit)
        {
            this.army.Add(unit);
        }
    }
}