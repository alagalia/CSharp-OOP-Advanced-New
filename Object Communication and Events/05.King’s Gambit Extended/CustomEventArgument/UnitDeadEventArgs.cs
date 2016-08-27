namespace _05.King_s_Gambit_Extended.CustomEventArgument
{
    using System;

    public class UnitDeadEventArgs : EventArgs
    {
        public UnitDeadEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}