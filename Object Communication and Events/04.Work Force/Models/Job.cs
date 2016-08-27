namespace _04.Work_Force.Models
{
    using System;

    using _04.Work_Force.CustomEventArgs;
    using _04.Work_Force.Interfaces;

    public delegate void JobDoneEventHandler(object sender, JobDoneEventArgs args);

    public class Job
    {
        private readonly IEmployee employee;

        public Job(string name, int hoursOfWorkRequired, IEmployee employee)
        {
            this.Name = name;
            this.employee = employee;
            this.HoursOfWorkRequired = hoursOfWorkRequired;
        }

        public event JobDoneEventHandler JobDone;

        public string Name { get; }

        public int HoursOfWorkRequired { get; private set; }

        public void Update()
        {
            this.HoursOfWorkRequired -= this.employee.Hours;
            if (this.HoursOfWorkRequired <= 0)
            {
                this.JobDone(this, new JobDoneEventArgs(this.Name));
            }
        }
    }
}