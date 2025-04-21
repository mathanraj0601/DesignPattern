using DesignPattern.code.Factory_Pattern.Components;

namespace DesignPattern.code.Factory_Pattern
{
    public class AbstractFactoryPattern
    {

        public void Demo()
        {
            IGUIFactory gUIFactory = new MacGUIFactory();
            gUIFactory.CreateButton().onClick();
            gUIFactory.createCheckbox().onCheck();
            
            gUIFactory = new WinGUIFactory();
            gUIFactory.CreateButton().onClick();
            gUIFactory.createCheckbox().onCheck();

        }
    }
}
