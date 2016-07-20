namespace _08.MilitaryElite.Models
{
    using System;

    using _08.MilitaryElite.Interfaces;

    public class Mission : IMission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    this.state = value;
                }
                else
                {
                    throw new ArgumentException("State of mission is not correct!");
                }
            }
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }

}