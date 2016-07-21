using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExplicitInterfaces
{
    using _10.ExplicitInterfaces.Interfaces;
    using _10.ExplicitInterfaces.Models;

    public class StartUp
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] token = line.Split();
                string name = token[0];
                string country = token[1];
                int age = int.Parse(token[2]);
                IPerson iperson = new Citizen(name, age, country);
                IResident iresident = new Citizen(name, age, country);
                Console.WriteLine(iperson.GetName());
                Console.WriteLine(iresident.GetName());
                line = Console.ReadLine();
            }
        }
    }
}
