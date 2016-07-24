namespace _03.GenericBoxInteger
{
    using System;

    public class BoxInteger
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = int.Parse(Console.ReadLine());
                Console.WriteLine(new Box<int>(line));
            }
        }
    }

    public class Box<T>
    {

        public Box(T value)
        {
            this.Value = value;
        }

        private T Value { get; set; }

        public override string ToString()
        {
            return this.Value.GetType().FullName + ": " + this.Value;
        }
    }

}
