namespace _11.TupleEx
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine().Split();
            CustomTuple<string, string> nameAdress = new CustomTuple<string, string>(tokens[0] + " " + tokens[1], tokens[2]);

            tokens = Console.ReadLine().Split();
            CustomTuple<string, int> nameBeer = new CustomTuple<string, int>(tokens[0], int.Parse(tokens[1]));

            tokens = Console.ReadLine().Split();
            CustomTuple<int, double> intDouble = new CustomTuple<int, double>(int.Parse(tokens[0]), double.Parse(tokens[1]));

            Console.WriteLine(nameAdress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(intDouble);
        }
    }   

    public class CustomTuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public CustomTuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
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
            return this.item1 + " -> " + this.item2;
        }
    }
}
