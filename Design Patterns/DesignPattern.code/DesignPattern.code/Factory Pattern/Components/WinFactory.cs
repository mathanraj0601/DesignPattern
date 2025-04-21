namespace DesignPattern.code.Factory_Pattern.Components
{
    public class WinFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
    }
}
