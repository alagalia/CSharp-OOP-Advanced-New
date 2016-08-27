using _11.CreateCustomClassAttribute.Contracts;

namespace _11.CreateCustomClassAttribute.IO
{
    public abstract class Command :ICommand
    {

        public abstract void Execute();
    }
}