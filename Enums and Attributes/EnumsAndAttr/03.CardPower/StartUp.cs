namespace _03.CardPower
{
    using System;

    [Serializable]
    public class Program
    {
        public static void Main()
        {
            //var rankFirst = Console.ReadLine();
            //var suitFirst = Console.ReadLine();
            //Card first = new Card(suitFirst, rankFirst);
            //var rankSecond = Console.ReadLine();
            //var suitSecond = Console.ReadLine();
            //Card second = new Card(suitSecond, rankSecond);
            //Console.WriteLine(first.CompareTo(second) >= 1 ? first : second);

            var attributes = typeof(Program).GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
