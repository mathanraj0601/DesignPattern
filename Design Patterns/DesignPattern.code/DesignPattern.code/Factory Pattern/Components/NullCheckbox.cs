namespace DesignPattern.code.Factory_Pattern.Components
{
    internal class NullCheckbox : ICheckbox
    {
        public void onCheck()
        {
            Console.WriteLine("");
        }
    }
}
