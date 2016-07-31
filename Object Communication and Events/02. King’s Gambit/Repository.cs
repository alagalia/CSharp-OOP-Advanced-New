namespace _02.King_s_Gambit
{
    using System.Collections.Generic;

    using _02.King_s_Gambit.Interfaces;

    public class Repository
    {
        private Dictionary<string, IRemovable> army;

        public Repository()
        {
            this.army = new Dictionary<string, IRemovable>();
        }

        public IReadOnlyDictionary<string, IRemovable> Army => this.army;

        public void AddToRepository(string name, IRemovable item)
        {
            this.army[name] = item;
        }

        public void RemoveFromRepository(string name)
        {
            this.army.Remove(name);
        }
    }
}