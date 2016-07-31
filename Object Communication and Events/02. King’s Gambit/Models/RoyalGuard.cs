namespace _02.King_s_Gambit.Models
{
    using System;

    using _02.King_s_Gambit.Interfaces;

    public class RoyalGuard : Unit, IRemovable
    {
        private King king;

        public RoyalGuard(string name, King king)
            : base(name)
        {
            this.king = king;
            king.AttackEventHandler += this.King_AttackEventHandler;
        }

        private void King_AttackEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {base.Name} is defending!");
        }

        public void Kill()
        {
            this.king.AttackEventHandler -= this.King_AttackEventHandler;
        }
    }
}