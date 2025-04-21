using DesignPattern.code.Factory_Pattern.Components;

namespace DesignPattern.code.Factory_Pattern
{
    public class FactoryMethodPattern
    {
        public void Demo()
        {
            IButtonFactory buttonFactory = new MacFactory();
            buttonFactory.CreateButton().onClick();

            buttonFactory = new WinFactory();
            buttonFactory.CreateButton().onClick();
        }
    }
}
