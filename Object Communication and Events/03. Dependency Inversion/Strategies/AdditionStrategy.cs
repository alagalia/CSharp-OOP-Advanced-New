namespace _03.Dependency_Inversion
{
    using _03.Dependency_Inversion.Interfaces;

    public class AdditionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
