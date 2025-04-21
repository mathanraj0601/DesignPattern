namespace DesignPattern.code.Factory_Pattern.Components
{
    public class WinCheckbox : ICheckbox
    {
        public void onCheck()
        {
            Console.WriteLine("Win Checkbox clicked");
        }
    }
}
