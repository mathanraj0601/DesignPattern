namespace DesignPattern.code.Factory_Pattern.Components
{
    internal class MacFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
    }
}
