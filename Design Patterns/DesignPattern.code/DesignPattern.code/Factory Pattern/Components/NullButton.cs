namespace DesignPattern.code.Factory_Pattern.Components
{
    internal class NullButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("");
        }
    }
}
