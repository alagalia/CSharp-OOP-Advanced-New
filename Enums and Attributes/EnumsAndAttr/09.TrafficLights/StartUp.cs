using System.Linq;

namespace _09.TrafficLights
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public enum LightColor
        {
            Red,
            Green,
            Yellow
        }

        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<LightColor> alLightColors = input.Select(lightColor => (LightColor) Enum.Parse(typeof(LightColor), lightColor)).ToList();

            int updates = int.Parse(Console.ReadLine());
            for (int i = 0; i < updates; i++)
            {   
                int realEnumUpdater = i + 1;
                Console.WriteLine(GetStringOfAllLights(alLightColors, realEnumUpdater));
            }
        }

        private static string GetStringOfAllLights(List<LightColor> alLightColors, int realEnumUpdater)
        {
            var allColors = alLightColors.Select(color => (LightColor) (((int) color + realEnumUpdater)%3)).Select(temp => temp.ToString()).ToList();

            return string.Join(" ", allColors);
        }
    }
}
