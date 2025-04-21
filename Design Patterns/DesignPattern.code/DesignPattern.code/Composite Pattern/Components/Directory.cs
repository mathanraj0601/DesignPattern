namespace DesignPattern.code.Composite_Pattern.Components
{
    internal class Directory : INode
    {
        List<INode> files;
        string name;
        public Directory(string name)
        {
            this.name = name;
            files = new List<INode>();
        }
        public void Ls()
        {
            Console.WriteLine($"Directory name : {name}");
            foreach (var node in files)
                node.Ls();
        }

        public void AddFileOrDirectory(INode node)
        {
            files.Add(node);
        }
    }
}
