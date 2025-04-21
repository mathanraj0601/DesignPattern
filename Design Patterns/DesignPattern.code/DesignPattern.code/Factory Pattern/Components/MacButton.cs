namespace DesignPattern.code.Factory_Pattern.Components
{
    public class MacButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Mac Button clicked");
        }
    }
}