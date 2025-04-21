namespace DesignPattern.code.Factory_Pattern.Components
{
    public class WinGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox createCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
