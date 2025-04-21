namespace DesignPattern.code.Factory_Pattern.Components
{
    internal class MacGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox createCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
