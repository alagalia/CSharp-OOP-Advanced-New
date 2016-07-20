namespace _08.MilitaryElite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using _08.MilitaryElite.Interfaces;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstname, string lastName, double salary)
            : base(id, firstname, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; }

        public void AddPrivate(IPrivate priv)
        {
            this.Privates.Add(priv);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine().AppendLine("Privates:");

            if (this.Privates.Count != 0)
            {
                string allPrivates = "  " + string.Join(Environment.NewLine + "  ", this.Privates);
                result.Append(allPrivates);
            }

            return result.ToString();
        }
    }

}