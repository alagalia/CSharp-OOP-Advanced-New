namespace _03.Dependency_Inversion.Strategies
{
    using _03.Dependency_Inversion.Interfaces;

    public class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
