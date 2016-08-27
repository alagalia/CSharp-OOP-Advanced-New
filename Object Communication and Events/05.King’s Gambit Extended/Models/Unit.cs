namespace _02.King_s_Gambit.Models
{
    using System;

    using _05.King_s_Gambit_Extended.CustomEventArgument;

    public delegate void UnitDeadEventHandler(object sender, UnitDeadEventArgs args);

    public abstract class Unit
    {
        private int lifes;

        protected Unit(string name, int lifes)
        {
            this.Name = name;
            this.lifes = lifes;
        }

        public event UnitDeadEventHandler UnitIsDead;

        public string Name { get; }

        public override string ToString()
        {
            return this.Name;
        }

        public void Kill()
        {
            this.lifes--;
            if (this.lifes == 0)
            {
                this.OnUnitDie(new UnitDeadEventArgs(this.Name));
            }
        }

        public abstract void OnKingAttack(object sender, EventArgs args);

        private void OnUnitDie(UnitDeadEventArgs unitDeadEventArgs)
        {
            this.UnitIsDead(this, unitDeadEventArgs);
        }
    }
}