namespace _04.Work_Force.CustomEventArgs
{
    using System;

    public class JobDoneEventArgs : EventArgs
    {
        public JobDoneEventArgs(string name)
        {
            this.Name = name;
        }

         public string Name { get; }
    }
}