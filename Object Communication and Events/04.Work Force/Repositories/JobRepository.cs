namespace _04.Work_Force.Repositories
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using _04.Work_Force.CustomEventArgs;
    using _04.Work_Force.Models;

    public class JobRepository : ArrayList
    {

        private List<Job> jobs;

        public JobRepository()
        {
            this.jobs = new List<Job>();
        }

        public void AddJob(Job job)
        {
            this.jobs.Add(job);
        }

        public void Update() 
        {
            var jobsToUpdate = new List<Job>(this.jobs);

            foreach (Job job in jobsToUpdate)
            {
                job.Update();
            }
        }

        public void FinishedJob(object sender, JobDoneEventArgs args)
        {
            Console.WriteLine($"Job {args.Name} done!");
            var job = this.jobs
                .FirstOrDefault(j => j.Name == args.Name);

            this.jobs.Remove(job);
        }

        public void Status()
        {
            foreach (var job in this.jobs)
            {
                Console.WriteLine($"Job: {job.Name} Hours Remaining: {job.HoursOfWorkRequired}");
            }
        }
    }
}