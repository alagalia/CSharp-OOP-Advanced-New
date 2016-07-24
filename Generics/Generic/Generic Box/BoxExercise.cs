using System;

namespace Generic_Box
{
    public class BoxExercise    
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                Console.WriteLine(new Box<string>(line));
            }
        }
    }

    public class Box<T>
    {

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return this.Value.GetType().FullName + ": " + this.Value;
        }
    }
}
