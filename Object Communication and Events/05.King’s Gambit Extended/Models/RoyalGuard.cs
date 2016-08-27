namespace _05.King_s_Gambit_Extended.Models
{
    using System;
    using _02.King_s_Gambit.Interfaces;
    using _02.King_s_Gambit.Models;

    public class RoyalGuard : Unit, IRemovable
    {
        private const int Lifes = 3;

        public RoyalGuard(string name)
            : base(name, Lifes)
        {
        }

        public override void OnKingAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {base.Name} is defending!");
        }
    }
}