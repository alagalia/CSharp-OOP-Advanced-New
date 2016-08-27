using _11.CreateCustomClassAttribute.Contracts;
using _11.CreateCustomClassAttribute.Models.Gems;

namespace _11.CreateCustomClassAttribute.Factory.GemsFactory
{
    public class GemFactory
    {
        public Gem ProduceRuby(GemClarities gemClarities)
        {
            return new Ruby(gemClarities);
        }

        public Gem ProduceEmerald(GemClarities gemClarities)
        {
            return new Emerald(gemClarities);
        }

        public Gem ProduceAmethyst(GemClarities gemClarities)
        {
            return new Amethyst(gemClarities);
        }
        
    }
}