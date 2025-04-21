namespace DesignPattern.code.Factory_Pattern.Components
{
    public interface IGUIFactory
    {
        public IButton CreateButton();
        public ICheckbox createCheckbox();
    }
}
