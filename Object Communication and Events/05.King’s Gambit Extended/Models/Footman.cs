namespace _02.King_s_Gambit.Models
{
    using System;
    using System.Runtime.Remoting.Channels;

    using _02.King_s_Gambit.Interfaces;

    using _05.King_s_Gambit_Extended.CustomEventArgument;

    public class Footman : Unit, IRemovable
    {
        private const int Lifes = 2;
            
        public Footman(string name)
            : base(name, Lifes)
        {
        }

        public override void OnKingAttack(object sender, EventArgs args)
        {
            Console.WriteLine(nameof(Footman) + $" {base.Name} is panicking!");
        }
    }
}