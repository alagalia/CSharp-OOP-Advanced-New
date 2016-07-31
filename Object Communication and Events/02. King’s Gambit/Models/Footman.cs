namespace _02.King_s_Gambit.Models
{
    using System;
    using _02.King_s_Gambit.Interfaces;

    public class Footman : Unit, IRemovable
    {
        private King king;

        public Footman(string name, King king)
            : base(name)
        {
            this.king = king;
            king.AttackEventHandler += this.King_AttackEventHandler;
        }

        private void King_AttackEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine(nameof(Footman) + $" {base.Name} is panicking!")            ;
        }

        public void Kill()
        {
            this.king.AttackEventHandler -= this.King_AttackEventHandler;
        }
    }
}