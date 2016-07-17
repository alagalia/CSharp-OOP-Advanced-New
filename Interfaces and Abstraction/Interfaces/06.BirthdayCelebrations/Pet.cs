﻿namespace _06.BirthdayCelebrations
{
    public class Pet : IUnit
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; }

        public string Birthdate { get; }
    }
}