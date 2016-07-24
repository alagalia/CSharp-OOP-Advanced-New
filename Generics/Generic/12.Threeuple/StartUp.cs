using System;

namespace _12.Threeuple
{
    class StartUp
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();
            Threeuple<string, string, string> nameAdress = new Threeuple<string, string, string>(tokens[0] + " " + tokens[1], tokens[2], tokens[3]);

            tokens = Console.ReadLine().Split();
            bool drunk = tokens[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> nameBeer = new Threeuple<string, int, bool>(tokens[0], int.Parse(tokens[1]), drunk);

            tokens = Console.ReadLine().Split();
            Threeuple<string, double, string> intDouble = new Threeuple<string, double, string>(tokens[0], double.Parse(tokens[1]), tokens[2]);

            Console.WriteLine(nameAdress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(intDouble);
        }
    }

    public class Threeuple<T1, T2, T3>
    {
        private T1 item1;
        private T2 item2;
        private T3 item3;

        public Threeuple(T1 item1, T2 item2, T3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public T3 Item3
        {
            get
            {
                return this.item3;
            }

            set
            {
                if (value == null)
                {
                    throw new Exception("value cannot be null!");
                }

                this.item3 = value;
            }
        }

        public T2 Item2
        {
            get
            {
                return this.item2;
            }

            set
            {
                if (value == null)
                {
                    throw new Exception("value cannot be null!");
                }

                this.item2 = value;
            }
        }

        public T1 Item1
        {
            get
            {
                return this.item1;
            }

            set
            {
                if (value == null)
                {
                    throw new Exception("value cannot be null!");
                }

                this.item1 = value;
            }
        }

        public override string ToString()
        {
            return this.item1 + " -> " + this.item2 + " -> " + this.item3;
        }
    }

}
