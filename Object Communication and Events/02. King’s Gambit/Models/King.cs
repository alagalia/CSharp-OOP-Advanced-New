namespace _02.King_s_Gambit.Models
{
    using System;
    using _02.King_s_Gambit.Interfaces;


    public class King : Unit, IAttackable
    {
        public event EventHandler AttackEventHandler;

        public King(string name)
            : base(name)
        {   
        }
        
        public void RespondToAttack()
        {
            Console.WriteLine($"King {base.Name} is under attack!");
            this.OnKingAttack();
        }

        private void OnKingAttack()
        {
            EventHandler onAttackEventHandler = this.AttackEventHandler;
            onAttackEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}