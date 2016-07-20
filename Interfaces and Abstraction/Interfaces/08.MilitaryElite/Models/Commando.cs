namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using System.Text;

    using _08.MilitaryElite.Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstname, string lastName, double salary, string corps)
            : base(id, firstname, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; }

        public void AddMission(IMission mission)
        {
            this.Missions.Add(mission);
        }
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.Append("Missions:");
            if (this.Missions.Count != 0)
            {
                result.AppendLine()
                    .Append(string.Join("\n", this.Missions));
            }

            return result.ToString();
        }
    }

}