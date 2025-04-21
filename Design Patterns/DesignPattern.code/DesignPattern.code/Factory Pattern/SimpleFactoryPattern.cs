using DesignPattern.code.Factory_Pattern.Components;

namespace DesignPattern.code.Factory_Pattern
{
    public class SimpleFactoryPattern
    {

        public void Demo()
        {
            ButtonSimpleFactory simpleFactory = new ButtonSimpleFactory();
            simpleFactory.GetButton("MAC").onClick();
            simpleFactory.GetButton("WINDOW").onClick();
        }
    }
}
