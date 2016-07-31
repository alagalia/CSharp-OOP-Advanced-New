namespace _03.Dependency_Inversion
{
    using _03.Dependency_Inversion.Interfaces;
    using _03.Dependency_Inversion.Strategies;

    public class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator(IStrategy initAStrategy)
        {
            this.strategy = initAStrategy;
        }

        public void ChangeStrategy(char @operator)
        {
            switch (@operator)
            {
                case '+':
                    this.strategy = new AdditionStrategy();
                    break;
                case '-':
                    this.strategy = new SubtractionStrategy();
                    break;
                case '/':
                    this.strategy = new DivideStrategy();
                    break;
                case '*':
                    this.strategy = new MultiplyStrategy();
                    break;
            }
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}