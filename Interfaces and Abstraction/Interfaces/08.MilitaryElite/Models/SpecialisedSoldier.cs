namespace _08.MilitaryElite.Models
{
    using System;

    using _08.MilitaryElite.Interfaces;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        protected SpecialisedSoldier(int id, string firstname, string lastName, double salary, string corps)
            : base(id, firstname, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            set
            {
                if (!value.Equals("Airforces") && !value.Equals("Marines"))
                {
                    throw new InvalidOperationException();
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Corps: {this.Corps}";
        }
    }

}