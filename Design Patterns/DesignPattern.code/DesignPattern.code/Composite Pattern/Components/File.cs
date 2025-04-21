namespace DesignPattern.code.Composite_Pattern.Components
{
    public class File : INode
    {
        private string name;
        public File(string name)
        {
            this.name = name;
        }
        public void Ls()
        {
            Console.WriteLine($" File Name : {name}");
        }

    }
}
