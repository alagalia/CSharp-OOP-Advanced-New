namespace _02.King_s_Gambit.Models
{
    using System;
    using _02.King_s_Gambit.Interfaces;

    using _05.King_s_Gambit_Extended.CustomEventArgument;

    public class King : IAttackable
    {
        public event EventHandler AttackKingEventHandler;
        public King(string name)
        {
            this.Name = name;
        }

        string Name { get; set; }

        public void RespondToAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            this.OnKingAttack();
        }

        private void OnKingAttack()
        {
            this.AttackKingEventHandler(this, new UnitDeadEventArgs(this.Name));
        }
    }
}