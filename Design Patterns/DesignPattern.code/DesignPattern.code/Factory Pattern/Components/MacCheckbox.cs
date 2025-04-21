namespace DesignPattern.code.Factory_Pattern.Components
{
    public class MacCheckbox : ICheckbox
    {
        public void onCheck()
        {
            Console.WriteLine("Mac Checkbox checked");
        }
    }
}
