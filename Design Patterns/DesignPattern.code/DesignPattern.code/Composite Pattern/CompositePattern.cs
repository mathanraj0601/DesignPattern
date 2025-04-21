namespace DesignPattern.code.Composite_Pattern
{
    public class CompositePattern
    {
        public void Demo()
        {
            Components.Directory directory = new Components.Directory("Folder 1");
            Components.File file = new Components.File("File 1");
            directory.AddFileOrDirectory(file);
            Components.Directory directory2 = new Components.Directory("Folder 2");
            Components.File file2 = new Components.File("File 2");
            Components.File file3 = new Components.File("File 3");
            directory2.AddFileOrDirectory(file2);
            directory2.AddFileOrDirectory(file3);
            directory.AddFileOrDirectory(directory2);

            directory.Ls();
        }
    }
}
