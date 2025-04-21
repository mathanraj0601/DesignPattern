namespace DesignPattern.code.Factory_Pattern.Components
{
    public class WinButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Win Button is Clicked");
        }
    }
}
