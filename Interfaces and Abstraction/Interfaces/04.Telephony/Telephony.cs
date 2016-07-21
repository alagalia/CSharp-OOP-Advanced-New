namespace _04.Telephony
{
    using System;
    using System.Linq;
    public class Telephony
    {
        public static void Main()
        {
            Smartphone smartphone = new Smartphone();

            string[] telNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();
            foreach (string number in telNumbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (string url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }

    public interface Icallable
    {
        string Call(string number);
    }

    public interface IBrowsable
    {
        string Browse(string url);
    }


    public class Smartphone : Icallable, IBrowsable
    {
        public string Call(string number)
        {
            bool allCharactersInStringAreDigits = number.All(char.IsDigit);
            if (!allCharactersInStringAreDigits)
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            bool containsInt = url.Any(char.IsDigit);
            if (containsInt)
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }
    }
}
